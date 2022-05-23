using HandballStatistics.EntityFramework.Factories;
using HandballStatistics.Interfaces.Services;
using HandballStatistics.Models;
using HandballStatistics.Services.DbServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandballStatistics.Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataService<User> dataService = new GenericDataService<User>();
            bool check = dataService.Init().Result;
            Console.WriteLine($"{check}{Environment.NewLine}");

            dataService = new GenericDataService<User>();
            User user = dataService.Get(1).Result;
            Console.WriteLine($"Name: {user.UserName}\nEmail: {user.Email}\nPassword: {user.Password}\nDate joined: {user.DateJoined.ToShortDateString()}");

            Console.ReadLine();
        }
    }
}
