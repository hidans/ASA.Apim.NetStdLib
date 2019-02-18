using ASA.Apim.NetStdLib.Security;
using ASA.Apim.NetStdLib.UserAgentBehavior;
using CourseHeader_WebService;
using CourseLocationList_WebService;
using System.ServiceModel;
using Teacher_WebService;
using EnvironmentAppsettings;

namespace ASA.Apim.NetStdLib.Helpers
{
    public static class ServiceClientHelper
    {
        private static CustomUserAgentEndpointBehavior NewEndpointBehavior(string AccountKey, string SubscriptionKey)
        {
            var credentials = new ApiManagerCredentials()
            {
                AccountKey = AccountKey,
                SubscriptionKey = SubscriptionKey
            };

            return new CustomUserAgentEndpointBehavior(credentials);
        }

        internal static CourseHeader_ServiceClient CourseHeaderServiceClient(string AccountKey, string SubscriptionKey, AppSettings appSettings)
        {
            var serviceClient = new CourseHeader_ServiceClient();
            serviceClient.Endpoint.EndpointBehaviors.Add(NewEndpointBehavior(AccountKey, SubscriptionKey));

            //Change the service endpoint address according to which Environment we running on.
            ChangeServiceEndpointAddress(appSettings, serviceClient);

            return serviceClient;
        }

        #region NonGeneric
        //private static void ChangeServiceEndpointAddress(AppSettings appSettings, CourseHeader_ServiceClient serviceClient)
        //{
        //    string serviceUrl = serviceClient.Endpoint.Address.ToString();
        //    if (serviceUrl.EndsWith("/"))
        //    {
        //        serviceUrl = serviceUrl.Remove(serviceUrl.LastIndexOf('/'));
        //    }

        //    var serviceName = serviceUrl.Substring(serviceUrl.LastIndexOf('/'));

        //    serviceClient.Endpoint.Address = new System.ServiceModel.EndpointAddress(appSettings.ApimUrl + serviceName);
        //}
        #endregion

        //Generic version, used for every service.
        private static void ChangeServiceEndpointAddress<T>(AppSettings appSettings, ClientBase<T> clientBase) where T:class
        {
            string serviceUrl = clientBase.Endpoint.Address.ToString();

            if (serviceUrl.EndsWith("/"))
            {
                serviceUrl = serviceUrl.Remove(serviceUrl.LastIndexOf('/'));
            }

            var serviceName = serviceUrl.Substring(serviceUrl.LastIndexOf('/'));

            clientBase.Endpoint.Address = new System.ServiceModel.EndpointAddress(appSettings.ApimUrl + serviceName);
        }

        internal static CourseLocationList_ServiceClient CourseLocationListServiceClient(string AccountKey, string SubscriptionKey, AppSettings appSettings)
        {
            var serviceClient = new CourseLocationList_ServiceClient();
            serviceClient.Endpoint.EndpointBehaviors.Add(NewEndpointBehavior(AccountKey, SubscriptionKey));

            //Change the service endpoint address according to which Environment we running on.
            ChangeServiceEndpointAddress(appSettings, serviceClient);

            return serviceClient;
        }

        internal static Teacher_ServiceClient TeacherServiceClient(string AccountKey, string SubscriptionKey, AppSettings appSettings)
        {
            var serviceClient = new Teacher_ServiceClient();
            serviceClient.Endpoint.EndpointBehaviors.Add(NewEndpointBehavior(AccountKey, SubscriptionKey));

            //Change the service endpoint address according to which Environment we running on.
            ChangeServiceEndpointAddress(appSettings, serviceClient);

            return serviceClient;
        }
    }
}