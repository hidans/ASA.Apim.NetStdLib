using ASA.Apim.NetStdLib.Security;
using ZoMineAppSettings;

namespace ASA.Apim.NetStdLib.Services
{
    public abstract class BaseService
    {
        protected AppSettings AppSettings { get; set; }
        protected ApiManagerCredentials Credentials { get; }

        public BaseService(ApiManagerCredentials credentials, AppSettings appSettings)
        {
            Credentials = credentials;
            AppSettings = appSettings;
        }
    }
}
