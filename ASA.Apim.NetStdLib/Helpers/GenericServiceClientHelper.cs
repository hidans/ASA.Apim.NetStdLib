using ASA.Apim.NetStdLib.Security;
using ASA.Apim.NetStdLib.UserAgentBehavior;
using System;
using System.ServiceModel;
using EnvironmentAppsettings;

namespace ASA.Apim.NetStdLib.Helpers
{
    public class GenericServiceClientHelper<TClient, TInterface>
        where TClient : ClientBase<TInterface>, TInterface
        where TInterface : class
    {
        private readonly ApiManagerCredentials _credentials;
        private readonly AppSettings _appSettings;

        public GenericServiceClientHelper(ApiManagerCredentials credentials, AppSettings appSettings)
        {
            _credentials = credentials;
            _appSettings = appSettings;
        }
        private CustomUserAgentEndpointBehavior NewEndpointBehavior()
        {
            return new CustomUserAgentEndpointBehavior(_credentials);
        }

        //Generic GetServiceClient(), that should replace XXServiceClient() methods used for every service XX.
        public TClient GetServiceClient()
        {
            TClient result = Activator.CreateInstance<TClient>() as TClient;//new CourseHeader_ServiceClient();
            ClientBase<TInterface> client = result as ClientBase<TInterface>;

            client.Endpoint.EndpointBehaviors.Add(NewEndpointBehavior());

            //Change the service endpoint address according to which Environment we running on.
            ChangeServiceEndpointAddress(client);

            return result;
        }

       //Generic version, used for every service.
        private void ChangeServiceEndpointAddress<T>(ClientBase<T> clientBase) where T : class
        {
            string serviceUrl = clientBase.Endpoint.Address.ToString();

            if (serviceUrl.EndsWith("/"))
            {
                serviceUrl = serviceUrl.Remove(serviceUrl.LastIndexOf('/'));
            }

            var serviceName = serviceUrl.Substring(serviceUrl.LastIndexOf('/'));

            clientBase.Endpoint.Address = new System.ServiceModel.EndpointAddress(_appSettings.ApimUrl + serviceName);
        }

    }
}
