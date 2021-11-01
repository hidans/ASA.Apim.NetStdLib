using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using CourseHeaderWithRef_WebService;
using EnvironmentAppsettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASA.Apim.NetStdLib.Services
{
    public class CourseHeaderWithRefService: BaseService
    {
        public CourseHeaderWithRefService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings){}

        #region CourseHeaderWithRef
        /// <summary>
        /// Get CourseHeaderWithRef with details from Navision, using No as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<string>> GetCourseHeaderWithRefById(string accountFromHeader, List<string> courseNos, int size = 0)
        {

            if (courseNos.Count() > 500)
            {
                var middle = courseNos.Count / 2;
                var res1 = await GetCourseHeaderWithRefById(accountFromHeader, courseNos.Take(middle).ToList(), size);
                var res2 = await GetCourseHeaderWithRefById(accountFromHeader, courseNos.Skip(middle).Take(courseNos.Count - middle).ToList(), size);
                return res1.Concat(res2);
            }

            var filter = Tools.GetCriteria(courseNos);
            var CourseHeaderWithReffilter = SingleCourseHeaderWithRefFilter(filter, courseHeaderWithRef_Fields.No);

            var results = await GetCourseHeaderWithRefsAsync(accountFromHeader, CourseHeaderWithReffilter, size);
            if (courseNos.Count() != results.Count())
            {
                return courseNos.Where(c => !results.Any(r => r.No == c));
            }

            return new List<string>();
        }

        internal async Task<IEnumerable<courseHeaderWithRef>> GetCourseHeaderWithRefsAsync(string accountFromHeader, courseHeaderWithRef_Filter[] filter, int size)
        {
            try
            {
                // Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<courseHeaderWithRef_ServiceClient, courseHeaderWithRef_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = await service.ReadMultipleAsync(filter, "", size);
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetCourseHeaderWithRefsAsync(): {exception.Message}");
            }
        }

        internal courseHeaderWithRef_Filter[] SingleCourseHeaderWithRefFilter(string criteria, courseHeaderWithRef_Fields field)
        {
            return new courseHeaderWithRef_Filter[]
            {
                new courseHeaderWithRef_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }
        #endregion
    }
}
