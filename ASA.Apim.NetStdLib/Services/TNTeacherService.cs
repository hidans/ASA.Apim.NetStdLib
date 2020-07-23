using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Interfaces;
using ASA.Apim.NetStdLib.Security;
using EnvironmentAppsettings;
using SalaryTeacherSpec_WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TN_TeacherUpdate_WebService;

namespace ASA.Apim.NetStdLib.Services
{
    public class TNTeacherService : ITNTeacherService
    {
        protected AppSettings AppSettings { get; set; }
        protected ApiManagerCredentials Credentials { get; }
        public TNTeacherService(string apimUrl, string subscriptionKey)
        {
            AppSettings = new AppSettings()
            {
                ApimUrl = apimUrl,
                SubscriptionKey = subscriptionKey
            };

            Credentials = new ApiManagerCredentials() { SubscriptionKey = subscriptionKey };
        }

        #region TN_TeacherUpdate
        /// <summary>
        /// Get TN_TeacherUpdates with details from Navision, using Teacher number as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<TN_TeacherUpdate>> GetTeacherById(string accountFromHeader, string filter, int size = 0)
        {
            if (string.IsNullOrEmpty(filter))
            {
                //throw new Exception("Filter cannot be null or empty string.");
                return new List<TN_TeacherUpdate>();
            }

            var TN_TeacherUpdatefilter = SingleTN_TeacherUpdateFilter(filter, TN_TeacherUpdate_Fields.No);
            return await GetTeachers(accountFromHeader, TN_TeacherUpdatefilter, size);
        }

        public async Task<IEnumerable<TN_TeacherUpdate>> GetTeachers(string accountFromHeader, string filter = "", int size = 0)
        {
            var TN_TeacherUpdatefilter = SingleTN_TeacherUpdateFilter(filter, TN_TeacherUpdate_Fields.No);
            return await GetTeachers(accountFromHeader, TN_TeacherUpdatefilter, size);
        }

        /// <summary>
        /// Get TN_TeacherUpdates with details from Navision, using TN_TeacherUpdate_Filter.
        /// </summary>
        /// <param name="filter">An instance of TN_TeacherUpdate_Filter.</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<TN_TeacherUpdate>> GetTeachers(string accountFromHeader, TN_TeacherUpdate_Filter[] filter, int size = 0)
        {
            return await GetTeachersAsync(accountFromHeader, filter, size);
        }

        internal async Task<IEnumerable<TN_TeacherUpdate>> GetTeachersAsync(string accountFromHeader, TN_TeacherUpdate_Filter[] filter, int size)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<TN_TeacherUpdate_ServiceClient, TN_TeacherUpdate_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = await service.ReadMultipleAsync(filter, "", size);
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetTN_TeacherUpdatesAsync(): {exception.Message}");
            }
        }

        internal TN_TeacherUpdate_Filter[] SingleTN_TeacherUpdateFilter(string criteria, TN_TeacherUpdate_Fields field)
        {
            return new TN_TeacherUpdate_Filter[]
            {
                new TN_TeacherUpdate_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }
        #endregion

    }
}
