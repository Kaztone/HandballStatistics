using HandballStatistics.Interfaces.Authenticators;
using HandballStatistics.Interfaces.Services;
using HandballStatistics.Models;
using System;
using System.Threading.Tasks;

namespace HandballStatistics.Services.AuthenticationServices
{
    public class Authenticator : ObservableObject, IAuthenticator
    {
        private readonly IAuthenticationService authenticationService;

        private Account currentAccount;

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

        public bool IsLoggedIn => this.CurrentAccount != null;

        public Authenticator(IAuthenticationService authenticationService)
        {
            this.authenticationService = authenticationService;
        }

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

        public void Logout()
        {
            this.CurrentAccount = null;
        }

        public async Task<RegistrationResult> Register(string username, string email, string password, string confirmPassword)
        {
            return await this.authenticationService.Register(username, email, password, confirmPassword);
        }      
    }
}
