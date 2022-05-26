namespace HandballStatistics.ViewModels
{
    public class TrackGameViewModel : ViewModelBase
    {
        private string username;

        private string welcomeMessage;

        public string Username
        {
            get => this.username;
            set
            {
                this.username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string WelcomeMessage
        {
            get => this.welcomeMessage;
            set
            {
                this.welcomeMessage = value;
                OnPropertyChanged(nameof(WelcomeMessage));
            }
        }

        public TrackGameViewModel()
        {
            this.username = "David";
            this.welcomeMessage = $"Welcome {this.username}!";
        }
    }
}
