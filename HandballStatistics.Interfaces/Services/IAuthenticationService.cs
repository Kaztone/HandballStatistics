using HandballStatistics.Models;
using System.Threading.Tasks;

namespace HandballStatistics.Interfaces.Services
{
    public interface IAuthenticationService
    {
        Task<bool> Register(string username, string email, string password, string confirmPassword);

        Task<Account> Login(string username, string password);
    }
}
