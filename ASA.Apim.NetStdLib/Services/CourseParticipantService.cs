using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using CourseParticipant_WebService;
using EnvironmentAppsettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASA.Apim.NetStdLib.Services
{
    public class CourseParticipantService : BaseService
    {
        public CourseParticipantService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings)
        {

        }

        #region CourseParticipant
        /// <summary>
        /// Get CourseParticipants with details from Navision, using Course_Header number as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseParticipant>> GetCourseParticipantByIdAsync(string accountFromHeader, string filter = "", int size = 0)
        {
            var CourseParticipantfilter = SingleCourseParticipantFilter(filter, CourseParticipant_Fields.Course_Header_No);
            var task = await GetCourseParticipantsAsync(accountFromHeader, CourseParticipantfilter, size);
            return task;
        }

        /// <summary>
        /// Get MDCourseParticipants with details from Navision, using Course_Header number as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseParticipant>> GetMDCourseParticipantByIdAsync(string accountFromHeader, IList<string> courseNos, int size = 0)
        {
            var courseParticipantNosFilter = Tools.GetCriteria(courseNos);

            if (string.IsNullOrEmpty(courseParticipantNosFilter))
            {
                return new List<CourseParticipant>();
            }

            var CourseParticipantfilter = SingleCourseParticipantFilter(courseParticipantNosFilter, CourseParticipant_Fields.Course_Header_No);
            var task = await GetCourseParticipantsAsync(accountFromHeader, CourseParticipantfilter, size);
            return task;
        }

        //public async Task<IEnumerable<CourseParticipant>> GetCourseParticipantsAsync(string accountFromHeader, int size = 0)
        //{
        //    return await GetCourseParticipantByIdAsync(accountFromHeader, "");
        //}

        /// <summary>
        /// Get CourseParticipants with details from Navision, using CourseParticipant_Filter.
        /// </summary>
        /// <param name="filter">An instance of SalaryTeacherSpec_Filter.</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseParticipant>> GetCourseParticipantsAsync(string accountFromHeader, CourseParticipant_Filter[] filter, int size = 0)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                //var service = ServiceClientHelper.CourseHeaderServiceClient(accountKey, subscriptionKey, appSettings);//Original

                #region usingGenerics
                //Client must gå through GenericServiceHelper.GetClient() to get credentials and environment ApimUrl. To Test.
                var genericServiceClientHelper = new GenericServiceClientHelper<CourseParticipant_ServiceClient, CourseParticipant_Service>(Credentials, AppSettings); //Generic non static Class
                var service = genericServiceClientHelper.GetServiceClient();
                #endregion

                var response = await service.ReadMultipleAsync(filter, "", size);
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetCourseParticipant(): {exception.Message}");
            }
        }

        internal CourseParticipant_Filter[] SingleCourseParticipantFilter(string criteria, CourseParticipant_Fields field)
        {
            return new CourseParticipant_Filter[]
            {
                new CourseParticipant_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }
        #endregion
    }
}
