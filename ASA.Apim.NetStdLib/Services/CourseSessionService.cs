using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using CourseSession_WebService;
using EnvironmentAppsettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASA.Apim.NetStdLib.Services
{
    public class CourseSessionService : BaseService
    {
        public CourseSessionService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings){}

        #region CourseSession
        /// <summary>
        /// Get CourseSessions with details from Navision, using CourseSession number as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseSession>> GetCourseSessionByIdAsync(string accountFromHeader, string filter, int size = 0)
        {
            if (string.IsNullOrEmpty(filter))
            {
                //throw new Exception("Filter cannot be null or empty string.");
                return new List<CourseSession>();
            }

            var CourseSessionfilter = SingleCourseSessionFilter(filter, CourseSession_Fields.Course_Header_No);
            return await GetCourseSessionsAsync(accountFromHeader, CourseSessionfilter, size);
        }

        /// <summary>
        /// Get CourseSessions with details from Navision, using CourseSession number as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseSession>> GetCourseSessionByIdAndDateAsync(string accountFromHeader, string filter, DateTime fromDate, int size = 0)
        {
            if (string.IsNullOrEmpty(filter))
            {
                //throw new Exception("Filter cannot be null or empty string.");
                return new List<CourseSession>();
            }

            var CourseSessionfilter = SingleCourseSessionFilter(filter, CourseSession_Fields.Course_Header_No);
            var extendedCourseSessionfilter = ExtendCourseSessionFilter(CourseSessionfilter, ">=" + fromDate.ToString("MM/dd/yyyy hh:mm:ss tt"), CourseSession_Fields.Date);
            return await GetCourseSessionsAsync(accountFromHeader, extendedCourseSessionfilter, size);
        }

        /// <summary>
        /// Get CourseSessions with details from Navision, using CourseSession_Filter.
        /// </summary>
        /// <param name="filter">An instance of SalaryTeacherSpec_Filter.</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseSession>> GetCourseSessionsAsync(string accountFromHeader, CourseSession_Filter[] filter, int size = 0)
        {
            return await GetCourseSessionAsync(accountFromHeader, filter, size);
        }

        internal async Task<IEnumerable<CourseSession>> GetCourseSessionAsync(string accountFromHeader, CourseSession_Filter[] filter, int size)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<CourseSession_ServiceClient, CourseSession_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = await service.ReadMultipleAsync(filter, "", size);
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetCourseSessionAsync(): {exception.Message}");
            }
        }

        internal CourseSession_Filter[] SingleCourseSessionFilter(string criteria, CourseSession_Fields field)
        {
            return new CourseSession_Filter[]
            {
                new CourseSession_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }

        internal CourseSession_Filter[] ExtendCourseSessionFilter(CourseSession_Filter[] filter, string criteria, CourseSession_Fields field)
        {
            return filter.Concat(SingleCourseSessionFilter(criteria, field)).ToArray();
        }
        #endregion

    }
}
