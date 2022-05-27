using HandballStatistics.Commands;
using HandballStatistics.Interfaces.Authenticators;
using HandballStatistics.Interfaces.Navigators;
using HandballStatistics.Interfaces.ViewModels;
using System.Windows.Input;

namespace HandballStatistics.ViewModels
{
    /// <summary>
    /// Base class for LoginViewModel.
    /// Derives from <see cref="ViewModelBase"/> class.
    /// </summary>
    public class LoginViewModel : ViewModelBase, ILoginViewModel
    {
        #region-----------------------------Fields---------------------------------------------
        /// <summary>
        /// Private field for username.
        /// </summary>
        private string username;

        /// <summary>
        /// Private field for username.
        /// </summary>
        private string password;
        #endregion

        #region-----------------------------Constructor,Destrucor,Dispose,Clone----------------       
        /// <summary>
        /// Prevents a default instance of the <see cref="LoginViewModel"/> class from being created.
        /// Initializes a new instance of the <see cref="HandballStatistics.ViewModels.LoginViewModel" /> class. 
        /// </summary>
        /// <param name="authenticator">Registered authentication service.</param>
        /// <param name="renavigator">Registered service.</param>
        public LoginViewModel(IAuthenticator authenticator, IRenavigator renavigator)
        {
            this.LoginCommand = new LoginCommand(this, authenticator, renavigator);
        }
        #endregion

        #region-----------------------------Properties, Indexer--------------------------------
        /// <summary>
        /// Gets or sets username.
        /// </summary>
        public string Username
        {
            get => this.username;
            set
            {
                this.username = value;
                this.OnPropertyChanged(nameof(this.username));
            }
        }

        /// <summary>
        /// Gets or sets password.
        /// </summary>
        public string Password
        {
            get => this.password;
            set
            {
                this.password = value;
                this.OnPropertyChanged(nameof(this.username));
            }
        }
        #endregion

        #region-----------------------------Comands--------------------------------------------
        /// <summary>
        /// Gets LoginCommand.
        /// </summary>
        public ICommand LoginCommand { get; }
        #endregion       
    }
}
