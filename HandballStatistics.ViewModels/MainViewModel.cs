using HandballStatistics.Commands;
using HandballStatistics.Interfaces.Authenticators;
using HandballStatistics.Interfaces.Navigators;
using HandballStatistics.Interfaces.ViewModels;
using System.Windows.Input;

namespace HandballStatistics.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IViewModelAbstractFactory viewModelAbstractFactory;

        public INavigator Navigator { get; set; }       

        public IAuthenticator Authenticator { get; set; }

        public ICommand UpdateCurrentViewModelCommand { get; }

        public ICommand GoToWebsiteCommand { get; set; }

        public MainViewModel(INavigator navigator,IViewModelAbstractFactory viewModelAbstractFactory, IAuthenticator authenticator)
        {
            this.Navigator = navigator;
            this.viewModelAbstractFactory = viewModelAbstractFactory;
            this.Authenticator = authenticator;

            this.UpdateCurrentViewModelCommand = new UpdateCurrentViewModelCommand(navigator, viewModelAbstractFactory);
            this.UpdateCurrentViewModelCommand.Execute(ViewType.Login);

            this.GoToWebsiteCommand = new GoToWebsiteCommand();
        }
    }
}
