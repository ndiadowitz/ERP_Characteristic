using SAP.Middleware.Connector;

namespace Characteristics.erp
{
    public class ErpConnection : IDestinationConfiguration
    {
        public ErpConnection(string destination, string user, string password, string systemId, int systemNumber,
            string appServerHost)
        {
            Destination = destination;
            User = user;
            Password = password;
            SystemId = systemId;
            SystemNumber = systemNumber;
            AppServerHost = appServerHost;


            PoolSize = 5;
            Language = "EN";
            Client = 100;
        }

        public string Destination { private set; get; }

        public int PoolSize { set; get; }
        public string Language { set; get; }
        public int Client { set; get; }
        private string Password { set; get; }
        private string User { set; get; }
        private string SystemId { set; get; }
        private int SystemNumber { set; get; }
        private string AppServerHost { set; get; }


        public RfcConfigParameters GetParameters(string destinationName)
        {
            var parameters = new RfcConfigParameters();

            if (!destinationName.Equals(Destination))
                return parameters;

            parameters.Add(RfcConfigParameters.AppServerHost, AppServerHost);
            parameters.Add(RfcConfigParameters.SystemNumber, SystemNumber.ToString());
            parameters.Add(RfcConfigParameters.SystemID, SystemId);
            parameters.Add(RfcConfigParameters.User, User);
            parameters.Add(RfcConfigParameters.Password, Password);
            parameters.Add(RfcConfigParameters.Client, Client.ToString());
            parameters.Add(RfcConfigParameters.Language, Language);
            parameters.Add(RfcConfigParameters.PoolSize, PoolSize.ToString());

            return parameters;
        }

        public bool ChangeEventsSupported()
        {
            throw new System.NotImplementedException();
        }

        public event RfcDestinationManager.ConfigurationChangeHandler ConfigurationChanged;
    }
}