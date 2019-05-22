using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using EnvironmentAppsettings;
using Municipality_WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASA.Apim.NetStdLib.Services
{
    public class MunicipalityService:BaseService
    {
        public MunicipalityService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings)
        {
        }

        #region Municipality
        /// <summary>
        /// Get Municipality with details from Navision, using Municipal_code as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<Municipality>> GetMunicipalityById(string filter = "", int size = 0)
        {
            var Municipalityfilter = SingleMunicipalityFilter(filter, Municipality_Fields.Municipal_Code);
            return await GetMunicipalitiesAsync(Municipalityfilter, size);
        }

        // <summary>
        /// Get all Municipalities with details from Navision.
        /// </summary>
        /// <param name="subscriptionKey">Signup in Api Manager to get a key. [Required]</param>
        /// <param name="accountKey">Account key from Navision. [Required]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<Municipality>> GetMunicipalities(int size = 0)
        {
            return await GetMunicipalityById("");
        }

        /// <summary>
        /// Get Municipalities with details from Navision, using Municipality_Filter.
        /// </summary>
        /// <param name="filter">An instance of Municipality_Filter.</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<Municipality>> GetMunicipalities(Municipality_Filter[] filter, int size = 0)
        {
            return await GetMunicipalitiesAsync(filter, size);
        }

        internal async Task<IEnumerable<Municipality>> GetMunicipalitiesAsync(Municipality_Filter[] filter, int size)
        {
            try
            {
                var genericServiceClientHelper = new GenericServiceClientHelper<Municipality_ServiceClient, Municipality_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = service.ReadMultipleAsync(filter, "", size).Result;
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetMunicipalitiesAsync(): {exception.Message}");
            }
        }

        internal Municipality_Filter[] SingleMunicipalityFilter(string criteria, Municipality_Fields field)
        {
            return new Municipality_Filter[]
            {
                new Municipality_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }
        #endregion
    }
}
