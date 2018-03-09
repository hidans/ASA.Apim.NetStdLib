using ASA.Apim.NetStdLib.Security;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace ASA.Apim.NetStdLib.UserAgentBehavior
{
    public class CustomUserAgentEndpointBehavior : IEndpointBehavior
    {
        private readonly ApiManagerCredentials _credentials;

        public CustomUserAgentEndpointBehavior(ApiManagerCredentials credentials)
        {
            _credentials = credentials;
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            clientRuntime.ClientMessageInspectors.Add(new CustomUserAgentClientMessageInspector(_credentials));
        }

        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {
            
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
           
        }
        public void Validate(ServiceEndpoint endpoint)
        {
            
        }
    }
}