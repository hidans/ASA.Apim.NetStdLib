using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using CourseHeader_WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoMineAppSettings;

namespace ASA.Apim.NetStdLib.Services
{
    public class CourseService
    {
        private readonly ApiManagerCredentials _credentials;
        private readonly AppSettings _appSettings;

        public CourseService(ApiManagerCredentials credentials, AppSettings appSettings)
        {
            _credentials = credentials;
            _appSettings = appSettings;
        }

        #region CourseHeader
        /// <summary>
        /// Get one course with details from Navision, using course number
        /// </summary>
        /// <param name="courseNumber">Course id/number</param>
        /// <param name="subscriptionKey">Signup in Api Manager to get a key. [Required]</param>
        /// <param name="accountKey">Account key from Navision. [Required]</param>
        /// <returns></returns>
        public async Task<CourseHeader> GetCourseHeader(string courseNumber)
        {
            return await GetCourseHeaderAsync(courseNumber);
        }
        internal async Task<CourseHeader> GetCourseHeaderAsync(string courseNumber)
        {
            try
            {
                var genericServiceClientHelper = new GenericServiceClientHelper<CourseHeader_ServiceClient, CourseHeader_Service>(_credentials, _appSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = service.ReadAsync(courseNumber).Result;
                await service.CloseAsync();

                return response.CourseHeader;
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetCourseHeader(): {exception.Message}");
            }
        }

        #endregion

        #region CourseHeaders
        public IEnumerable<CourseHeader> GetCourseHeadersById(string filter = "", int size = 0)
        {
            var CourseHeaderfilter = SingleCourseHeaderFilter(filter, CourseHeader_Fields.No);
            var task = GetCourseHeaders(CourseHeaderfilter, size);
            return task.Result;
        }
        public IEnumerable<CourseHeader> GetCourseHeaders(int size = 0)
        {
            return GetCourseHeadersById("");
        }

        public async Task<IEnumerable<CourseHeader>> GetCourseHeaders(CourseHeader_Filter[] filter, int size = 0)
        {
            try
            {
                //var service = ServiceClientHelper.CourseHeaderServiceClient(accountKey, subscriptionKey, appSettings);//Original

                #region usingGenerics
                //Client must gå through GenericServiceHelper.GetClient() to get credentials and environment ApimUrl. To Test.
                var genericServiceClientHelper = new GenericServiceClientHelper<CourseHeader_ServiceClient, CourseHeader_Service>(_credentials, _appSettings); //Generic non static Class
                var service = genericServiceClientHelper.GetServiceClient();
                #endregion

                var response = service.ReadMultipleAsync(filter, "", size).Result;
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetCourseHeaders(): {exception.Message}");
            }
        }

        internal CourseHeader_Filter[] SingleCourseHeaderFilter(string criteria, CourseHeader_Fields field)
        {
            return new CourseHeader_Filter[]
            {
                new CourseHeader_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }
        #endregion
    }
}
