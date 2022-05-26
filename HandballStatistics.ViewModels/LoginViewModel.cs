using HandballStatistics.Commands;
using HandballStatistics.Interfaces.Authenticators;
using HandballStatistics.Interfaces.Navigators;
using HandballStatistics.Interfaces.ViewModels;

using System.Windows.Input;

namespace HandballStatistics.ViewModels
{
    public class LoginViewModel : ViewModelBase, ILoginViewModel
    {
        private string username;
        
        private string password; 

        public string Username 
        {
            get => this.username;
            set
            {
                this.username = value;
                OnPropertyChanged(nameof(this.username));
            } 
        }

        public string Password
        {
            get => this.password;
            set
            {
                this.password = value;
                OnPropertyChanged(nameof(this.username));
            }
        }

        public ICommand LoginCommand { get; }
        

        public LoginViewModel(IAuthenticator authenticator, IRenavigator renavigator)
        {
            this.LoginCommand = new LoginCommand(this, authenticator, renavigator);
        }
        
    }
}
