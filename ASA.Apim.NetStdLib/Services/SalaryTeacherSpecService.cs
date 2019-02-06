using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using SalaryTeacherSpec_WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZoMineAppSettings;

namespace ASA.Apim.NetStdLib.Services
{
    public class SalaryTeacherSpecService: BaseService
    {
        public SalaryTeacherSpecService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings)
        {

        }

        #region SalaryTeacherSpec
        /// <summary>
        /// Get SalaryTeacherSpecs with details from Navision, using Teacher number as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<SalaryTeacherSpec>> GetSalaryTeacherSpecById(string accountFromHeader, string filter, int size = 0)
        {
            if (string.IsNullOrEmpty(filter))
            {
                //throw new Exception("Filter cannot be null or empty string.");
                return new List<SalaryTeacherSpec>();
            }

            var SalaryTeacherSpecfilter = SingleSalaryTeacherSpecFilter(filter, SalaryTeacherSpec_Fields.No);
            return await GetSalaryTeacherSpecs(accountFromHeader, SalaryTeacherSpecfilter, size);
        }

        /// <summary>
        /// Get SalaryTeacherSpecs with details from Navision, using SalaryTeacherSpec_Filter.
        /// </summary>
        /// <param name="filter">An instance of SalaryTeacherSpec_Filter.</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<SalaryTeacherSpec>> GetSalaryTeacherSpecs(string accountFromHeader, SalaryTeacherSpec_Filter[] filter, int size = 0)
        {
            return await GetSalaryTeacherSpecsAsync(accountFromHeader, filter, size);
        }

        internal async Task<IEnumerable<SalaryTeacherSpec>> GetSalaryTeacherSpecsAsync(string accountFromHeader, SalaryTeacherSpec_Filter[] filter, int size)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<SalaryTeacherSpec_ServiceClient, SalaryTeacherSpec_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = service.ReadMultipleAsync(filter, "", size).Result;
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetSalaryTimeSpecsAsync(): {exception.Message}");
            }
        }

        internal SalaryTeacherSpec_Filter[] SingleSalaryTeacherSpecFilter(string criteria, SalaryTeacherSpec_Fields field)
        {
            return new SalaryTeacherSpec_Filter[]
            {
                new SalaryTeacherSpec_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }
        #endregion

    }
}
