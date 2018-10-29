using SAP.Middleware.Connector;

namespace Characteristics.erp
{
    public abstract class Erp
    {
        private ErpConnection _connection;

        private readonly RfcRepository _repository;

        protected Erp(ErpConnection connection)
        {
            _connection = connection;

            RfcDestinationManager.RegisterDestinationConfiguration(connection);

            var dest = RfcDestinationManager.GetDestination(connection.Destination);

            _repository = dest.Repository;
        }

        protected RfcRepository GetRepository()
        {
            return _repository;
        }
    }
}