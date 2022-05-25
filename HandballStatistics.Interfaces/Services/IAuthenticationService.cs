using HandballStatistics.Models;
using System.Threading.Tasks;

namespace HandballStatistics.Interfaces.Services
{
    public enum RegistrationResult
    {
        Success,
        PasswordsDoNotMatch,
        EmailAlreadyExists,
        UsernameAlrreadyExists
    }

    public interface IAuthenticationService
    {
        Task<RegistrationResult> Register(string username, string email, string password, string confirmPassword);

        Task<Account> Login(string username, string password);
    }
}
