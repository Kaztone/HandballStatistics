using HandballStatistics.Exceptions;
using HandballStatistics.Interfaces.Services;
using HandballStatistics.Models;
using System;
using System.Threading.Tasks;

namespace HandballStatistics.Services.AuthenticationServices
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IAccountDataService accountService;

        public AuthenticationService(IAccountDataService accountService)
        { 
            this.accountService = accountService;
        }

        public async Task<Account> Login(string username, string password)
        {
            Account storedAccount = await this.accountService.GetByUsername(username);

            return (storedAccount.AccountHolder.Password != password) ? throw new InvalidPasswordException(username, password) : storedAccount;
        }

        public async Task<RegistrationResult> Register(string username, string email, string password, string confirmPassword)
        {
            RegistrationResult registrationResult = RegistrationResult.Success;

            if (password != confirmPassword)
            {
                registrationResult = RegistrationResult.PasswordsDoNotMatch;
            }

            Account emailAccount = await this.accountService.GetByEmail(email);

            if(emailAccount != null)
            {
                registrationResult = RegistrationResult.EmailAlreadyExists;
            }

            Account usernameAccount = await this.accountService.GetByUsername(username);

            if(usernameAccount != null)
            {
                registrationResult = RegistrationResult.UsernameAlrreadyExists;
            }

            if(registrationResult == RegistrationResult.Success)
            {
                User user = new User()
                {
                    UserName = username,
                    Email = email,
                    Password = password,
                    DateJoined = DateTime.Now.Date
                };

                Account account = new Account(user);

                await this.accountService.Create(account);
            }

            return registrationResult;
        }
    }
}
