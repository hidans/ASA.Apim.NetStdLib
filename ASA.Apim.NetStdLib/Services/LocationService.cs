using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using EnvironmentAppsettings;
using Location_WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASA.Apim.NetStdLib.Services
{
    public class LocationService : BaseService
    {
        public LocationService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings) { }

        #region Location
        /// <summary>
        /// Get Locations with details from Navision, using Location number as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<Location>> GetLocationByIdAsync(string accountFromHeader, string filter = "", int size = 0)
        {
            //if (string.IsNullOrEmpty(filter))
            //{
            //    //throw new Exception("Filter cannot be null or empty string.");
            //    return new List<Location>();
            //}

            var Locationfilter = SingleLocationFilter(filter, Location_Fields.No);
            return await GetLocationsAsync(accountFromHeader, Locationfilter, size);
        }

        /// <summary>
        /// Get Locations with details from Navision, using Location_Filter.
        /// </summary>
        /// <param name="filter">An instance of SalaryTeacherSpec_Filter.</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<Location>> GetLocationsAsync(string accountFromHeader, Location_Filter[] filter, int size = 0)
        {
            return await GetLocationAsync(accountFromHeader, filter, size);
        }

        internal async Task<IEnumerable<Location>> GetLocationAsync(string accountFromHeader, Location_Filter[] filter, int size)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<Location_ServiceClient, Location_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = await service.ReadMultipleAsync(filter, "", size);
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetLocationAsync(): {exception.Message}");
            }
        }

        internal Location_Filter[] SingleLocationFilter(string criteria, Location_Fields field)
        {
            return new Location_Filter[]
            {
                new Location_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }
        #endregion

    }
}
