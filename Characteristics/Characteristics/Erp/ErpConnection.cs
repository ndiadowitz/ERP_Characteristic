using System.ServiceModel.Description;

namespace Characteristics.erp
{
    /// <summary>
    /// ErpConnection ist used by <see cref="Erp"/> to get login information.
    /// </summary>
    public class ErpConnection
    {
        /// <summary>
        /// Default constructor
        ///
        /// This is not the best handling of login information.
        /// </summary>
        /// <param name="userName">Username</param>
        /// <param name="password">Password</param>
        public ErpConnection(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }


        /// <summary>
        /// Password
        /// </summary>
        private string Password { get; }
        /// <summary>
        /// Username
        /// </summary>
        private string UserName { get; }

        /// <summary>
        /// Set username and password in <see cref="ClientCredentials"/>
        /// </summary>
        /// <param name="clientCredentials"></param>
        public void SetClientCredentials(ClientCredentials clientCredentials)
        {
            clientCredentials.UserName.UserName = UserName;
            clientCredentials.UserName.Password = Password;
        }
    }
}