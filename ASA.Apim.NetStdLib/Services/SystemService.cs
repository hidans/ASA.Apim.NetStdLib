using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using EnvironmentAppsettings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SystemService_WebService;

namespace ASA.Apim.NetStdLib.Services
{
    public class SystemService
    {
        protected AppSettings AppSettings { get; set; }
        protected ApiManagerCredentials Credentials { get; }

        public SystemService(string apimUrl, string subscriptionKey)
        {
            AppSettings = new AppSettings()
            {
                ApimUrl = apimUrl,
                SubscriptionKey = subscriptionKey
            };

            Credentials = new ApiManagerCredentials() { SubscriptionKey = subscriptionKey };
        }

        #region CompaniesResponse
        /// <summary>
        /// Get all Companies from Navision.
        /// </summary>
        /// <returns></returns>
        public async Task<CompaniesResponse> GetCompaniesAsync(string accountFromHeader)
        {
            return await GetIntCompaniesAsync(accountFromHeader);
        }

        internal async Task<CompaniesResponse> GetIntCompaniesAsync(string accountFromHeader)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<SystemService_ServiceClient, SystemService_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = await service.CompaniesAsync();
                await service.CloseAsync();
                return response;
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetCompagniesAsync(): {exception.Message}");
            }
        }

        #endregion
    }
}
