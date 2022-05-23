using HandballStatistics.EntityFramework.Contexts;
using HandballStatistics.Interfaces.Services;
using HandballStatistics.Models;
using HandballStatistics.Services.AuthenticationServices;
using HandballStatistics.Services.DbServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HandballStatistics.Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataService<User> dataService = new GenericDataService<User>(
                new HandballStatisticsDbContext());

            IDataService<Account> accountDataService = new AccountDataService(
                new HandballStatisticsDbContext());

            IAuthenticationService authenticationService = new AuthenticationService(accountDataService);

            // Check connection GenericDataService
            bool check = dataService.Init().Result;
            Console.WriteLine($"GenericDataService datbase connection established: {check}{Environment.NewLine}");

            // Check connection AccountDataService
            bool check2 = accountDataService.Init().Result;
            Console.WriteLine($"AccountDataService datbase connection established: {check}{Environment.NewLine}");

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

            // Check "Get" AccountDataService
            Account account = accountDataService.Get(1).Result;
            account.AccountHolder = dataService.Get(account.AccountHolderId).Result;
            Console.WriteLine(
                $"AccountId: {account.Id}\n" +
                $"AccountHolderId: {account.AccountHolderId}\n" +
                $"AccountHolderName: {account.AccountHolder.UserName}\n"
            );

            // Check Register
            //authenticationService.Register("registrationTest", "test@hotmail.com", "registrationTest", "registrationTest");

            // Check number of Users and Accounts
            Console.WriteLine(
                $"Total users: {dataService.GetAll().Result.Count()}\n" +
                $"Total accounts: {accountDataService.GetAll().Result.Count()}\n"
            );

            Console.ReadLine();
        }
    }
}
