using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using DiscountCodes_WebService;
using EnvironmentAppsettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASA.Apim.NetStdLib.Services
{
    public class DiscountService: BaseService
    {
        public DiscountService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings)
        {

        }

        #region Discount
        /// <summary>
        /// Get DiscountCodes which are common to all courses.
        /// </summary>
        /// <param name="subscriptionKey">Signup in Api Manager to get a key. [Required]</param>
        /// <param name="accountKey">Account key from Navision. [Required]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        private async Task<IEnumerable<DiscountCodes>> GetCommonDiscountCodes(string accountFromHeader, int size = 0)
        {
            var DiscountCodesfilter = SingleDiscountCodesFilter("True", DiscountCodes_Fields.Valid_For_School);
            var validForSchoolDiscountCodes = await GetDiscountCodes(accountFromHeader, DiscountCodesfilter, size);
            return validForSchoolDiscountCodes.Where(d => d.Course_Header_No == string.Empty || d.Course_Header_No == null);
        }

        /// <summary>
        /// Get DiscountCodes with details from Navision, using Course number as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<DiscountCodes>> GetDiscountCodesByCourseNo(string accountFromHeader, string filter, int size = 0)
        {
            if (string.IsNullOrEmpty(filter))
            {
                //throw new Exception("Filter cannot be null or empty string.");
                return new List<DiscountCodes>();
            }

            var DiscountCodesfilter = SingleDiscountCodesFilter(filter, DiscountCodes_Fields.Course_Header_No);
            var results = await GetCommonDiscountCodes(accountFromHeader);
            return results.Concat(await GetDiscountCodes(accountFromHeader, DiscountCodesfilter, size));
        }

        /// <summary>
        /// Get DiscountCodes with details from Navision, using DiscountCodes_Filter.
        /// </summary>
        /// <param name="filter">An instance of DiscountCodes_Filter.</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<DiscountCodes>> GetDiscountCodes(string accountFromHeader, DiscountCodes_Filter[] filter, int size = 0)
        {
            return await GetDiscountCodesAsync(accountFromHeader, filter, size);
        }

        internal async Task<IEnumerable<DiscountCodes>> GetDiscountCodesAsync(string accountFromHeader, DiscountCodes_Filter[] filter, int size)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<DiscountCodes_ServiceClient, DiscountCodes_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = await service.ReadMultipleAsync(filter, "", size);
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                //throw new Exception($"Error in DiscountCodes(): {exception.Message}");
                throw new Exception($"Error in DiscountCodes(): {exception}");
            }
        }

        internal DiscountCodes_Filter[] SingleDiscountCodesFilter(string criteria, DiscountCodes_Fields field)
        {
            return new DiscountCodes_Filter[]
            {
                new DiscountCodes_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }
        #endregion
    }
}
