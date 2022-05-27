using HandballStatistics.Commands;
using HandballStatistics.Interfaces.Authenticators;
using HandballStatistics.Interfaces.Navigators;
using HandballStatistics.Interfaces.ViewModels;
using System.Windows.Input;

namespace HandballStatistics.ViewModels
{
    /// <summary>
    /// Base class for MainViewModel.
    /// Derives from <see cref="ViewModelBase"/> class.
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        #region-----------------------------Fields---------------------------------------------
        /// <summary>
        /// Private readonly field for IViewModelAbstractFactory.
        /// </summary>
        private readonly IViewModelAbstractFactory viewModelAbstractFactory;
        #endregion

        #region-----------------------------Constructor,Destrucor,Dispose,Clone----------------       
        /// <summary>
        /// Prevents a default instance of the <see cref="MainViewModel"/> class from being created.
        /// Initializes a new instance of the <see cref="HandballStatistics.ViewModels.MainViewModel" /> class. 
        /// </summary>
        /// <param name="navigator">Registered navigation service.</param>
        /// <param name="viewModelAbstractFactory">Registered factory service.</param>
        /// <param name="authenticator">Registered authentication service.</param>
        public MainViewModel(INavigator navigator, IViewModelAbstractFactory viewModelAbstractFactory, IAuthenticator authenticator)
        {
            this.Navigator = navigator;
            this.viewModelAbstractFactory = viewModelAbstractFactory;
            this.Authenticator = authenticator;

            this.UpdateCurrentViewModelCommand = new UpdateCurrentViewModelCommand(navigator, viewModelAbstractFactory);
            this.UpdateCurrentViewModelCommand.Execute(ViewType.Login);

            this.GoToWebsiteCommand = new GoToWebsiteCommand();
        }
        #endregion

        #region-----------------------------Properties, Indexer--------------------------------
        /// <summary>
        /// Gets or sets Navigator.
        /// </summary>
        public INavigator Navigator { get; set; }

        /// <summary>
        /// Gets or sets Authenticator.
        /// </summary>
        public IAuthenticator Authenticator { get; set; }
        #endregion

        #region-----------------------------Comands--------------------------------------------
        /// <summary>
        /// Gets UpdateCurrentViewModelCommand.
        /// </summary>
        public ICommand UpdateCurrentViewModelCommand { get; }

        /// <summary>
        /// Gets or sets GoToWebsiteCommand.
        /// </summary>
        public ICommand GoToWebsiteCommand { get; set; }
        #endregion
    }
}
