using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using EnvironmentAppsettings;
using SalarySettlement_WebService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ASA.Apim.NetStdLib.Services
{
    public class AccountTransactionService : BaseService
    {
        public AccountTransactionService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings) { }

        #region AccountTransaction
        /// <summary>
        /// Create an AccountTransaction (a SalarySettle).
        /// </summary>
        /// <param name="request">The Request body contains SalarySettleRequest. [Required]</param>
        /// <returns>Returns SalarySettleResponse </returns>
        public async Task<SalarySettleResponse> CreateAccountTransaction(string accountFromHeader, SalarySettleRequest request)
        {
            return await CreateAccountTransactionAsync(accountFromHeader, request);
        }
        internal async Task<SalarySettleResponse> CreateAccountTransactionAsync(string accountFromHeader, SalarySettleRequest request)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<SalarySettlement_ServiceClient, SalarySettlement_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();
                var response = service.SalarySettleAsync(request).Result;
                
                await service.CloseAsync();

                return response;
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in CreateAccountTransaction(): {exception.Message}");
            }
        }

        #endregion
    }
}
