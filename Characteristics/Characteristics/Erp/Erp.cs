using System.ServiceModel.Description;

namespace Characteristics.erp
{
    public abstract class Erp
    {
        private ErpConnection Connection { get; }
        
        protected Erp(ErpConnection connection)
        {
            Connection = connection;
        }

        protected void SetCredentials(ClientCredentials clientCredentials)
        {
            Connection.SetClientCredentials(clientCredentials);
        }
    }
}