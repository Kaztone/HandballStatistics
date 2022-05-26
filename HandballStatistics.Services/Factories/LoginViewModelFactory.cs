using HandballStatistics.Interfaces.Authenticators;
using HandballStatistics.Interfaces.Navigators;
using HandballStatistics.Interfaces.ViewModels;
using HandballStatistics.ViewModels;

namespace HandballStatistics.Services.Factories
{
    public class LoginViewModelFactory : IViewModelFactory<LoginViewModel>
    {
        private readonly IAuthenticator authenticator;

        private readonly IRenavigator renavigator;

        public LoginViewModelFactory(IAuthenticator authenticator, IRenavigator renavigator)
        {
            this.authenticator = authenticator;
            this.renavigator = renavigator;
        }

        public LoginViewModel CreateViewModel()
        {
            return new LoginViewModel(this.authenticator, this.renavigator);
        }
    }
}
