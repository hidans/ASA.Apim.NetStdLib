using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using CourseWebStatus_WebService;
using EnvironmentAppsettings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ASA.Apim.NetStdLib.Services
{
    public class CourseWebStatusService : BaseService
    {
        public CourseWebStatusService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings)
        {
        }

        #region CourseWebStatus
        public async Task<string> GetNavOrderId(string accountFromHeader, string portalOrderId)
        {
            return await GetNavOrderIdAsync(accountFromHeader, portalOrderId);
        }
        internal async Task<string> GetNavOrderIdAsync(string accountFromHeader, string portalOrderId)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<CourseWebStatus_ServiceClient, CourseWebStatus_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = service.GetNavOrderIdAsync(portalOrderId).Result;
                await service.CloseAsync();
                return response.return_value;
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetNavOrderIdAsync(): {exception.Message}");
            }
        }

        public async Task<GetOrderStatusResponse> GetOrderStatus(string accountFromHeader, string portalOrderId, string navOrderId, string errorMessage)
        {
            return await GetOrderSatusAsync(accountFromHeader, portalOrderId, navOrderId, errorMessage);
        }

        internal async Task<GetOrderStatusResponse> GetOrderSatusAsync(string accountFromHeader, string portalOrderId, string navOrderId, string errorMessage)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<CourseWebStatus_ServiceClient, CourseWebStatus_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = service.GetOrderStatusAsync(portalOrderId, navOrderId, errorMessage).Result;
                await service.CloseAsync();
                return response;
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetOrderSatusAsync(): {exception.Message}");
            }
        }

        #endregion
    }
}
