namespace HandballStatistics.ViewModels
{
    /// <summary>
    /// Base class for ProfileViewModel.
    /// Derives from <see cref="ViewModelBase"/> class.
    /// </summary>
    public class ProfileViewModel : ViewModelBase
    {
        #region-----------------------------Fields---------------------------------------------
        /// <summary>
        /// Private field for username.
        /// </summary>
        private string username;

        /// <summary>
        /// Private field for welcomeMessage.
        /// </summary>
        private string welcomeMessage;
        #endregion

        #region-----------------------------Constructor,Destrucor,Dispose,Clone----------------       
        /// <summary>
        /// Prevents a default instance of the <see cref="ProfileViewModel"/> class from being created.
        /// Initializes a new instance of the <see cref="HandballStatistics.ViewModels.ProfileViewModel" /> class. 
        /// </summary>
        public ProfileViewModel()
        {
            this.username = "David";
            this.welcomeMessage = $"Welcome {this.username}!";
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
                this.OnPropertyChanged(nameof(this.Username));
            }
        }

        /// <summary>
        /// Gets or sets welcomeMessage.
        /// </summary>
        public string WelcomeMessage
        {
            get => this.welcomeMessage;
            set
            {
                this.welcomeMessage = value;
                this.OnPropertyChanged(nameof(this.WelcomeMessage));
            }
        }
        #endregion 
    }
}
