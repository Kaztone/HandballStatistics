using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandballStatistics.ViewModels
{
    public class ProfileViewModel : ViewModelBase
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

        public ProfileViewModel()
        {
            this.username = "David";
            this.welcomeMessage = $"Welcome {this.username}!";
        }
    }
}
