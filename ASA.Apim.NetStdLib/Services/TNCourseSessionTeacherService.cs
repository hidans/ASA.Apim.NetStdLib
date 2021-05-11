using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using EnvironmentAppsettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TN_CourseSessionTeacher_WebService;

namespace ASA.Apim.NetStdLib.Services
{
    public class TNCourseSessionTeacherService : BaseService
    {
        public TNCourseSessionTeacherService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings) { }

        #region TNCourseSessionTeacher
        /// <summary>
        /// Get TNCourseSessionTeachers with details from Navision, using TN_CourseSessionTeacher number as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<TN_CourseSessionTeacher>> GetTNCourseSessionTeacherByIdAsync(string accountFromHeader, string filter, int size = 0)
        {
            if (string.IsNullOrEmpty(filter))
            {
                //throw new Exception("Filter cannot be null or empty string.");
                return new List<TN_CourseSessionTeacher>();
            }

            var tN_CourseSessionTeacherfilter = SingleTNCourseSessionTeacherFilter(filter, TN_CourseSessionTeacher_Fields.Course_Header_No);
            return await GetTNCourseSessionTeachersAsync(accountFromHeader, tN_CourseSessionTeacherfilter, size);
        }

        /// <summary>
        /// Get MD CourseSessionTeachers with details from Navision, using TN_CourseSessionTeacher number as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<TN_CourseSessionTeacher>> GetMDTNCourseSessionTeacherAsync(string accountFromHeader, List<string> courseNos, int size = 0)
        {
            if (courseNos.Count() == 0)
            {
                return new List<TN_CourseSessionTeacher>();
            }

            var courseNosFilter = Tools.GetCriteria(courseNos);

            var tN_CourseSessionTeacherfilter = SingleTNCourseSessionTeacherFilter(courseNosFilter, TN_CourseSessionTeacher_Fields.Course_Header_No);
            return await GetTNCourseSessionTeachersAsync(accountFromHeader, tN_CourseSessionTeacherfilter, size);
        }


        /// <summary>
        /// Get CourseSessionTeachers with details from Navision, using TN_CourseSessionTeacher_Filter.
        /// </summary>
        /// <param name="filter">An instance of SalaryTeacherSpec_Filter.</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<TN_CourseSessionTeacher>> GetTNCourseSessionTeachersAsync(string accountFromHeader, TN_CourseSessionTeacher_Filter[] filter, int size = 0)
        {
            return await GetTNCourseSessionTeacherAsync(accountFromHeader, filter, size);
        }

        internal async Task<IEnumerable<TN_CourseSessionTeacher>> GetTNCourseSessionTeacherAsync(string accountFromHeader, TN_CourseSessionTeacher_Filter[] filter, int size)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<TN_CourseSessionTeacher_ServiceClient, TN_CourseSessionTeacher_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = await service.ReadMultipleAsync(filter, "", size);
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetTNCourseSessionTeacherAsync(): {exception.Message}");
            }
        }

        internal TN_CourseSessionTeacher_Filter[] SingleTNCourseSessionTeacherFilter(string criteria, TN_CourseSessionTeacher_Fields field)
        {
            return new TN_CourseSessionTeacher_Filter[]
            {
                new TN_CourseSessionTeacher_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }
        #endregion

    }
}
