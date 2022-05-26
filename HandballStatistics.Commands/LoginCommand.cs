using HandballStatistics.Interfaces.Authenticators;
using HandballStatistics.Interfaces.Navigators;
using HandballStatistics.Interfaces.ViewModels;

namespace HandballStatistics.Commands
{
    public class LoginCommand : CommandBase
    {
        private readonly ILoginViewModel loginViewModel;

        private readonly IAuthenticator authenticator;

        private readonly IRenavigator renavigator;

        public LoginCommand(ILoginViewModel loginViewModel, IAuthenticator authenticator, IRenavigator renavigator)
        {
            this.loginViewModel = loginViewModel;
            this.authenticator = authenticator;
            this.renavigator = renavigator;
        }

        public async override void Execute(object parameter)
        {
            bool success = await this.authenticator.Login(this.loginViewModel.Username, parameter.ToString());

            if (success)
            {
                this.renavigator.Renavigate();
            }
        }
    }
}
