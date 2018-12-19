using System.ServiceModel.Description;

namespace Characteristics.erp
{
    public class ErpConnection
    {
        public ErpConnection(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }


        private string Password { get; }
        private string UserName { get; }

        public void SetClientCredentials(ClientCredentials clientCredentials)
        {
            clientCredentials.UserName.UserName = UserName;
            clientCredentials.UserName.Password = Password;
        }
    }
}