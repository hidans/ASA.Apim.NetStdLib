using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using EnvironmentAppsettings;
using SalaryGLAccount_WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASA.Apim.NetStdLib.Services
{
    public class AccountService: BaseService
    {
        public AccountService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings) { }

        #region Account
        /// <summary>
        /// Get SalaryGLAccounts with details from Navision, using No as filter.
        /// </summary>
        /// <param name="accountFromHeader">Account</param>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<SalaryGLAccount>> GetSalaryGLAccountById(string accountFromHeader, string filter, int size = 0)
        {
            //if (string.IsNullOrEmpty(filter))
            //{
            //    //throw new Exception("Filter cannot be null or empty string.");
            //    return new List<SalaryGLAccount>();
            //}

            var SalaryGLAccountfilter = SingleSalaryGLAccountFilter(filter, SalaryGLAccount_Fields.No);
            return await GetSalaryGLAccounts(accountFromHeader, SalaryGLAccountfilter, size);
        }

        public async Task<IEnumerable<SalaryGLAccount>> GetSalaryGLAccounts(string accountFromHeader, int size = 0)
        {
            return await GetSalaryGLAccountById(accountFromHeader, "");
        }

        /// <summary>
        /// Get SalaryGLAccounts with details from Navision, using SalaryGLAccount_Filter.
        /// </summary>
        /// <param name="filter">An instance of SalaryGLAccount_Filter.</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<SalaryGLAccount>> GetSalaryGLAccounts(string accountFromHeader, SalaryGLAccount_Filter[] filter, int size = 0)
        {

            return await GetSalaryGLAccountsAsync(accountFromHeader, filter, size);
        }

        internal async Task<IEnumerable<SalaryGLAccount>> GetSalaryGLAccountsAsync(string accountFromHeader, SalaryGLAccount_Filter[] filter, int size)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<SalaryGLAccount_ServiceClient, SalaryGLAccount_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = service.ReadMultipleAsync(filter, "", size).Result;
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetSalaryGLAccountsAsync(): {exception.Message}");
            }
        }

        internal SalaryGLAccount_Filter[] SingleSalaryGLAccountFilter(string criteria, SalaryGLAccount_Fields field)
        {
            return new SalaryGLAccount_Filter[]
            {
                new SalaryGLAccount_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }
        #endregion
    }
}
