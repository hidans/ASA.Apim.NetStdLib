using ASA.Apim.NetStdLib.Security;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace ASA.Apim.NetStdLib.UserAgentBehavior
{
    public class CustomUserAgentClientMessageInspector : IClientMessageInspector
    {
        private readonly ApiManagerCredentials _credentials;

        public CustomUserAgentClientMessageInspector(ApiManagerCredentials credentials)
        {
            _credentials = credentials;
        }

        public object BeforeSendRequest(ref System.ServiceModel.Channels.Message request, IClientChannel channel)
        {
            if (_credentials != null)
            {
                if (request.Properties.Count == 0 || request.Properties[HttpRequestMessageProperty.Name] == null)
                {
                    var httpRequestMessageProperty = new HttpRequestMessageProperty();

                    if (!string.IsNullOrEmpty(_credentials.AccountKey))
                    {
                        httpRequestMessageProperty.Headers[Constants.RequestHeaderKeys.Account] = _credentials.AccountKey;
                    }

                    if (!string.IsNullOrEmpty(_credentials.SubscriptionKey))
                    {
                        httpRequestMessageProperty.Headers[Constants.RequestHeaderKeys.SubSubscriptionKey] = _credentials.SubscriptionKey;
                    }

                    request.Properties.Add(HttpRequestMessageProperty.Name, httpRequestMessageProperty);
                }
                else
                {
                    if (!string.IsNullOrEmpty(_credentials.AccountKey))
                    {
                        ((HttpRequestMessageProperty)request.Properties[HttpRequestMessageProperty.Name]).Headers[Constants.RequestHeaderKeys.Account] = _credentials.AccountKey;
                    }

                    if (!string.IsNullOrEmpty(_credentials.SubscriptionKey))
                    {
                        ((HttpRequestMessageProperty)request.Properties[HttpRequestMessageProperty.Name]).Headers[Constants.RequestHeaderKeys.SubSubscriptionKey] = _credentials.SubscriptionKey;
                    }
                }
            }
            return null;
        }

        public void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
        }
    }
}