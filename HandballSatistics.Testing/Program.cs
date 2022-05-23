using HandballStatistics.EntityFramework.Contexts;
using HandballStatistics.Interfaces.Services;
using HandballStatistics.Models;
using HandballStatistics.Services.AuthenticationServices;
using HandballStatistics.Services.DbServices;
using System;
using System.Linq;

namespace HandballStatistics.Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ------------------------------ Service Implementation --------------------------

            IDataService<User> dataService = new GenericDataService<User>(
                new HandballStatisticsDbContext());

            IAccountDataService accountDataService = new AccountDataService(
                new HandballStatisticsDbContext());

            IAuthenticationService authenticationService = new AuthenticationService(accountDataService);

            #endregion

            #region ------------------------------ GenericDataService ------------------------------

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Test: GenericDataService");
            Console.WriteLine("--------------------------------------------------\n");

            // Check connection GenericDataService
            bool check = dataService.Init().Result;
            Console.WriteLine($"GenericDataService database connection established: {check}{Environment.NewLine}");           

            // Check "Get" GenericDataService
            User user = dataService.Get(1).Result;
            Console.WriteLine(
                $"Id: {user.Id}\n" +
                $"Name: {user.UserName}\n" +
                $"Email: {user.Email}\n" +
                $"Password: {user.Password}\n" +
                $"Date joined: {user.DateJoined.ToShortDateString()}" +
                $"{Environment.NewLine}"
            );

            // Check "GetAll" GenericDataService
            int numberUsers = dataService.GetAll().Result.Count();
            Console.WriteLine($"Total users:{numberUsers}{Environment.NewLine}");

            Console.WriteLine("--------------------------------------------------");

            #endregion

            #region ------------------------------ AccountDataService ------------------------------

            Console.WriteLine("Test: AccountDataService");
            Console.WriteLine("--------------------------------------------------\n");

            // Check connection AccountDataService
            bool check2 = accountDataService.Init().Result;
            Console.WriteLine($"AccountDataService database connection established: {check}{Environment.NewLine}");

            // Check "Get" AccountDataService
            Account account = accountDataService.Get(1).Result;
            Console.WriteLine(
                $"AccountId: {account.Id}\n" +
                $"AccountHolderId: {account.AccountHolderId}\n" +
                $"AccountHolderName: {account.AccountHolder.UserName}\n"
            );

            Console.WriteLine("--------------------------------------------------");

            #endregion

            #region ------------------------------ AuthenticationService ---------------------------

            Console.WriteLine("Test: AccountDataService");
            Console.WriteLine("--------------------------------------------------\n");

            // Check AuthenticationService: Register
            // authenticationService.Register("registrationTest", "test@hotmail.com", "registrationTest", "registrationTest").Wait();
            Console.WriteLine(
                $"Total users: {dataService.GetAll().Result.Count()}\n" +
                $"Total accounts: {accountDataService.GetAll().Result.Count()}\n"
            );

            // Check AuthenticationService: Login
            account = authenticationService.Login("admin", "admin").Result;
            Console.WriteLine($"Logged in as: {account.AccountHolder.UserName}\n");

            Console.WriteLine("--------------------------------------------------");

            #endregion

            Console.ReadLine();
        }
    }
}
