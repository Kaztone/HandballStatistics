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

            if(storedAccount.AccountHolder.Password != password)
            {
                throw new Exception();
            }

            return storedAccount;
        }

        public async Task<bool> Register(string username, string email, string password, string confirmPassword)
        {
            bool success = false;

            if (password == confirmPassword)
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

                success = true;
            }

            return success;
        }
    }
}
