using ASA.Apim.NetStdLib.Security;
using ASA.Apim.NetStdLib.UserAgentBehavior;
using CourseHeader_WebService;
using CourseLocationList_WebService;

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

        internal static CourseHeader_ServiceClient CourseHeaderServiceClient(string AccountKey, string SubscriptionKey)
        {
            var serviceClient = new CourseHeader_WebService.CourseHeader_ServiceClient();
            serviceClient.Endpoint.EndpointBehaviors.Add(NewEndpointBehavior(AccountKey, SubscriptionKey));
            return serviceClient;
        }

        internal static CourseLocationList_ServiceClient CourseLocationListServiceClient(string AccountKey, string SubscriptionKey)
        {
            var serviceClient = new CourseLocationList_WebService.CourseLocationList_ServiceClient();
            serviceClient.Endpoint.EndpointBehaviors.Add(NewEndpointBehavior(AccountKey, SubscriptionKey));
            return serviceClient;
        }
    }
}