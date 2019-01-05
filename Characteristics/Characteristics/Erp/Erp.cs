using System.ServiceModel.Description;

namespace Characteristics.erp
{
    /// <summary>
    /// Erp
    /// </summary>
    public abstract class Erp
    {
        /// <summary>
        /// <see cref="ErpConnection"/> for login
        /// </summary>
        private ErpConnection Connection { get; }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="connection"><see cref="ErpConnection"/> information</param>
        protected Erp(ErpConnection connection)
        {
            Connection = connection;
        }

        /// <summary>
        /// Set login information in <see cref="ClientCredentials"/>
        /// </summary>
        /// <param name="clientCredentials"><see cref="ClientCredentials"/></param>
        protected void SetCredentials(ClientCredentials clientCredentials)
        {
            Connection.SetClientCredentials(clientCredentials);
        }
    }
}