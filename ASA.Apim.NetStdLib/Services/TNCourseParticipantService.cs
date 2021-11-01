using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using EnvironmentAppsettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TN_CourseParticipant_WebService;

namespace ASA.Apim.NetStdLib.Services
{
    public class TNCourseParticipantService : BaseService
    {
        public TNCourseParticipantService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings)
        {

        }

        #region TN_CourseParticipant
        /// <summary>
        /// Get TN_CourseParticipants with details from Navision, using Course_Header number as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<TN_CourseParticipant>> GetTN_CourseParticipantByIdAsync(string accountFromHeader, string filter = "", int size = 0)
        {
            var TN_CourseParticipantfilter = SingleTN_CourseParticipantFilter(filter, TN_CourseParticipant_Fields.Course_Header_No);
            var task = await GetTN_CourseParticipantsAsync(accountFromHeader, TN_CourseParticipantfilter, size);
            return task;
        }

        /// <summary>
        /// Get MDTN_CourseParticipants with details from Navision, using Course_Header number as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<TN_CourseParticipant>> GetMDTN_CourseParticipantByIdAsync(string accountFromHeader, IList<string> courseNos, int size = 0)
        {
            if (courseNos.Count() > 1000)
            {
                int filterIndex = courseNos.Count() / 2;
                var res1 = await GetMDTN_CourseParticipantByIdAsync(accountFromHeader, courseNos.Take(filterIndex).ToList(), size);
                var res2 = await GetMDTN_CourseParticipantByIdAsync(accountFromHeader, courseNos.Skip(filterIndex).ToList(), size);
                return res1.Concat(res2);
            }

            var courseParticipantNosFilter = Tools.GetCriteria(courseNos);
            
            if (string.IsNullOrEmpty(courseParticipantNosFilter))
            {
                return new List<TN_CourseParticipant>();
            }

            var TN_CourseParticipantfilter = SingleTN_CourseParticipantFilter(courseParticipantNosFilter, TN_CourseParticipant_Fields.Course_Header_No);
            var task = await GetTN_CourseParticipantsAsync(accountFromHeader, TN_CourseParticipantfilter, size);
            return task;
        }

        public async Task<IEnumerable<TN_CourseParticipant>> GetTN_CourseParticipantByIdAndStatusAsync(string accountFromHeader, Course_Line_Status status, string filter = "", int size = 0)
        {
            var TN_CourseParticipantfilter = SingleTN_CourseParticipantFilter(filter, TN_CourseParticipant_Fields.Course_Header_No);
            var extendedTN_CourseParticipantFilter = ExtendTN_CourseParticipantFilter(TN_CourseParticipantfilter, status.ToString(), TN_CourseParticipant_Fields.Course_Line_Status);
            var task = await GetTN_CourseParticipantsAsync(accountFromHeader, extendedTN_CourseParticipantFilter, size);
            return task;
        }

        //public async Task<IEnumerable<TN_CourseParticipant>> GetTN_CourseParticipantsAsync(string accountFromHeader, int size = 0)
        //{
        //    return await GetTN_CourseParticipantByIdAsync(accountFromHeader, "");
        //}

        /// <summary>
        /// Get TN_CourseParticipants with details from Navision, using TN_CourseParticipant_Filter.
        /// </summary>
        /// <param name="filter">An instance of SalaryTeacherSpec_Filter.</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<TN_CourseParticipant>> GetTN_CourseParticipantsAsync(string accountFromHeader, TN_CourseParticipant_Filter[] filter, int size = 0)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                //var service = ServiceClientHelper.CourseHeaderServiceClient(accountKey, subscriptionKey, appSettings);//Original

                #region usingGenerics
                //Client must gå through GenericServiceHelper.GetClient() to get credentials and environment ApimUrl. To Test.
                var genericServiceClientHelper = new GenericServiceClientHelper<TN_CourseParticipant_ServiceClient, TN_CourseParticipant_Service>(Credentials, AppSettings); //Generic non static Class
                var service = genericServiceClientHelper.GetServiceClient();
                #endregion

                var response = await service.ReadMultipleAsync(filter, "", size);
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetTN_CourseParticipant(): {exception.Message}");
            }
        }

        internal TN_CourseParticipant_Filter[] SingleTN_CourseParticipantFilter(string criteria, TN_CourseParticipant_Fields field)
        {
            return new TN_CourseParticipant_Filter[]
            {
                new TN_CourseParticipant_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }

        internal TN_CourseParticipant_Filter[] ExtendTN_CourseParticipantFilter(TN_CourseParticipant_Filter[] filter, string criteria, TN_CourseParticipant_Fields field)
        {
            return filter.Concat(SingleTN_CourseParticipantFilter(criteria, field)).ToArray();
        }
        #endregion
    }
}
