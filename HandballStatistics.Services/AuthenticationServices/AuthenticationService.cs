using HandballStatistics.Exceptions;
using HandballStatistics.Interfaces.Services;
using HandballStatistics.Models;
using System;
using System.Threading.Tasks;

namespace HandballStatistics.Services.AuthenticationServices
{
    /// <summary>
    /// Base class for AuthenticationService.
    /// Derives from <see cref="IAuthenticationService"/> class.
    /// </summary>
    public class AuthenticationService : IAuthenticationService
    {
        #region-----------------------------Fields---------------------------------------------
        /// <summary>
        /// Private field accountService.
        /// </summary>
        /// <remarks></remarks>
        private readonly IAccountDataService accountService;
        #endregion

        #region-----------------------------Constructor,Destrucor,Dispose,Clone----------------       
        /// <summary>
        /// Prevents a default instance of the <see cref="AuthenticationService"/> class from being created.
        /// Initializes a new instance of the <see cref="HandballStatistics.Services.AuthenticationServices.AuthenticationService" /> class. 
        /// </summary>
        /// <param name="accountService">Registrated IAccountDataService.</param>
        public AuthenticationService(IAccountDataService accountService)
        {
            this.accountService = accountService;
        }
        #endregion

        #region-----------------------------Methods--------------------------------------------
        /// <summary>
        /// Checks existence of Account and logs in if exists.
        /// </summary>
        /// <param name="username">String username.</param>
        /// <param name="password">String password.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public async Task<Account> Login(string username, string password)
        {
            Account storedAccount = await this.accountService.GetByUsername(username);

            return (storedAccount.AccountHolder.Password != password) ? throw new InvalidPasswordException(username, password) : storedAccount;
        }

        /// <summary>
        /// Checks existance of username, email and compares passwords.
        /// </summary>
        /// <param name="username">String username.</param>
        /// <param name="email">String email.</param>
        /// <param name="password">String password.</param>
        /// <param name="confirmPassword">String confirm password.</param>
        public async Task<RegistrationResult> Register(string username, string email, string password, string confirmPassword)
        {
            RegistrationResult registrationResult = RegistrationResult.Success;

            if (password != confirmPassword)
            {
                registrationResult = RegistrationResult.PasswordsDoNotMatch;
            }

            Account emailAccount = await this.accountService.GetByEmail(email);

            if (emailAccount != null)
            {
                registrationResult = RegistrationResult.EmailAlreadyExists;
            }

            Account usernameAccount = await this.accountService.GetByUsername(username);

            if (usernameAccount != null)
            {
                registrationResult = RegistrationResult.UsernameAlrreadyExists;
            }

            if (registrationResult == RegistrationResult.Success)
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
        #endregion





    }
}
