using HandballStatistics.Interfaces.Services;
using HandballStatistics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandballStatistics.Interfaces.Authenticators
{
    public interface IAuthenticator
    {
        Account CurrentAccount { get; }

        bool IsLoggedIn { get; }

        Task<RegistrationResult> Register(string username, string email, string password, string confirmPassword);

        Task<bool> Login(string username, string password);

        void Logout();

    }
}
