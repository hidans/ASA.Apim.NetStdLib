using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using CoursePriceType_WebService;
using EnvironmentAppsettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASA.Apim.NetStdLib.Services
{
    public class PriceService: BaseService
    {
        public PriceService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings)
        {
        }

        #region CoursePriceType
        /// <summary>
        /// Get CoursePriceTypes with details from Navision, using Course number as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CoursePriceType>> GetCoursePriceTypeById(string accountFromHeader, string filter, int size = 0)
        {
            if (string.IsNullOrEmpty(filter))
            {
                //throw new Exception("Filter cannot be null or empty string.");
                return new List<CoursePriceType>();
            }

            var CoursePriceTypefilter = SingleCoursePriceTypeFilter(filter, CoursePriceType_Fields.Course_Team);
            return await GetCoursePriceTypes(accountFromHeader, CoursePriceTypefilter, size);
        }

        /// <summary>
        /// Get CoursePriceType with details from Navision, using CoursePriceType_Filter.
        /// </summary>
        /// <param name="filter">An instance of CoursePriceType_Filter.</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CoursePriceType>> GetCoursePriceTypes(string accountFromHeader, CoursePriceType_Filter[] filter, int size = 0)
        {
            return await GetCoursePriceTypesAsync(accountFromHeader, filter, size);
        }

        internal async Task<IEnumerable<CoursePriceType>> GetCoursePriceTypesAsync(string accountFromHeader, CoursePriceType_Filter[] filter, int size)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<CoursePriceType_ServiceClient, CoursePriceType_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = service.ReadMultipleAsync(filter, "", size).Result;
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetCoursePriceTypes(): {exception.Message}");
            }
        }

        internal CoursePriceType_Filter[] SingleCoursePriceTypeFilter(string criteria, CoursePriceType_Fields field)
        {
            return new CoursePriceType_Filter[]
            {
                new CoursePriceType_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }
        #endregion
    }
}
