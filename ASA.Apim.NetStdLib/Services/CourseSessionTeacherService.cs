using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using CourseSessionTeacher_WebService;
using EnvironmentAppsettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASA.Apim.NetStdLib.Services
{
    public class CourseSessionTeacherService : BaseService
    {
        public CourseSessionTeacherService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings) { }

        #region CourseSessionTeacher
        /// <summary>
        /// Get CourseSessionTeachers with details from Navision, using CourseSessionTeacher number as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseSessionTeacher>> GetCourseSessionTeacherByIdAsync(string accountFromHeader, string filter, int size = 0)
        {
            if (string.IsNullOrEmpty(filter))
            {
                //throw new Exception("Filter cannot be null or empty string.");
                return new List<CourseSessionTeacher>();
            }

            var CourseSessionTeacherfilter = SingleCourseSessionTeacherFilter(filter, CourseSessionTeacher_Fields.Course_Header_No);
            return await GetCourseSessionTeachersAsync(accountFromHeader, CourseSessionTeacherfilter, size);
        }

        /// <summary>
        /// Get CourseSessionTeachers with details from Navision, using CourseSessionTeacher_Filter.
        /// </summary>
        /// <param name="filter">An instance of SalaryTeacherSpec_Filter.</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseSessionTeacher>> GetCourseSessionTeachersAsync(string accountFromHeader, CourseSessionTeacher_Filter[] filter, int size = 0)
        {
            return await GetCourseSessionTeacherAsync(accountFromHeader, filter, size);
        }

        internal async Task<IEnumerable<CourseSessionTeacher>> GetCourseSessionTeacherAsync(string accountFromHeader, CourseSessionTeacher_Filter[] filter, int size)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<CourseSessionTeacher_ServiceClient, CourseSessionTeacher_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = await service.ReadMultipleAsync(filter, "", size);
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetCourseSessionTeacherAsync(): {exception.Message}");
            }
        }

        internal CourseSessionTeacher_Filter[] SingleCourseSessionTeacherFilter(string criteria, CourseSessionTeacher_Fields field)
        {
            return new CourseSessionTeacher_Filter[]
            {
                new CourseSessionTeacher_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }
        #endregion

    }
}
