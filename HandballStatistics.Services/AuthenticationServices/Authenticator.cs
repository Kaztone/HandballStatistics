using HandballStatistics.Interfaces.Authenticators;
using HandballStatistics.Interfaces.Services;
using HandballStatistics.Models;
using System;
using System.Threading.Tasks;

namespace HandballStatistics.Services.AuthenticationServices
{
    /// <summary>
    /// Base class for Authenticator.
    /// Derives from <see cref="ObservableObject"/> class.
    /// Derives from <see cref="IAuthenticator"/> class.
    /// </summary>
    public class Authenticator : ObservableObject, IAuthenticator
    {
        #region-----------------------------Fields---------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        private Account currentAccount;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        private readonly IAuthenticationService authenticationService;
        #endregion

        #region-----------------------------Constructor,Destrucor,Dispose,Clone----------------       
        /// <summary>
        /// Initializes a new instance of the <see cref="HandballStatistics.Services.AuthenticationServices.Authenticator" /> class. 
        /// </summary>
        /// <param name="authenticationService"></param>
        /// <remarks></remarks>
        public Authenticator(IAuthenticationService authenticationService)
        {
            this.authenticationService = authenticationService;
        }
        #endregion

        #region-----------------------------Properties, Indexer--------------------------------
        /// <summary>
        /// Gets or sets .
        /// </summary>
        /// <value></value>
        /// <remarks></remarks>
        public Account CurrentAccount
        {
            get => this.currentAccount;
            private set
            {
                this.currentAccount = value;
                OnPropertyChanged(nameof(this.CurrentAccount));
                OnPropertyChanged(nameof(this.IsLoggedIn));
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance .
        /// </summary>
        /// <value>
        ///   <see langword="true" /> if this instance ; otherwise, <see langword="false" />.</value>
        /// <remarks></remarks>
        public bool IsLoggedIn => this.CurrentAccount != null;
        #endregion

        #region-----------------------------Methods--------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public async Task<bool> Login(string username, string password)
        {
            bool success = true;

            try
            {
                this.CurrentAccount = await this.authenticationService.Login(username, password);
            }
            catch (Exception)
            {
                success = false;
            }

            return success;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        public void Logout()
        {
            this.CurrentAccount = null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="confirmPassword"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public async Task<RegistrationResult> Register(string username, string email, string password, string confirmPassword)
        {
            return await this.authenticationService.Register(username, email, password, confirmPassword);
        }
        #endregion
    }
}
