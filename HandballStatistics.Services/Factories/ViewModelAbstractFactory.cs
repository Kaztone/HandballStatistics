using HandballStatistics.Interfaces.Navigators;
using HandballStatistics.Interfaces.ViewModels;
using HandballStatistics.ViewModels;
using System;


namespace HandballStatistics.Services.Factories
{
    public class ViewModelAbstractFactory : IViewModelAbstractFactory
    {
        private readonly IViewModelFactory<HomeViewModel> homeViewModelFactory;
        private readonly IViewModelFactory<TrackGameViewModel> trackGameViewModelFactory;
        private readonly IViewModelFactory<ViewStatsViewModel> viewStatsViewModelFactory;
        private readonly IViewModelFactory<ConfigurationViewModel> configurationViewModelFactory;
        private readonly IViewModelFactory<ProfileViewModel> profileViewModelFactory;
        private readonly IViewModelFactory<HelpViewModel> helpViewModelFactory;
        private readonly IViewModelFactory<LoginViewModel> loginViewModelFactory;

        public ViewModelAbstractFactory(
            IViewModelFactory<HomeViewModel> homeViewModelFactory,
            IViewModelFactory<TrackGameViewModel> trackGameViewModelFactory, 
            IViewModelFactory<ViewStatsViewModel> viewStatsViewModelFactory, 
            IViewModelFactory<ConfigurationViewModel> configurationViewModelFactory, 
            IViewModelFactory<ProfileViewModel> profileViewModelFactory, 
            IViewModelFactory<HelpViewModel> helpViewModelFactory,
            IViewModelFactory<LoginViewModel> loginViewModelFactory)
        {
            this.homeViewModelFactory = homeViewModelFactory;
            this.trackGameViewModelFactory = trackGameViewModelFactory;
            this.viewStatsViewModelFactory = viewStatsViewModelFactory;
            this.configurationViewModelFactory = configurationViewModelFactory;
            this.profileViewModelFactory = profileViewModelFactory;
            this.helpViewModelFactory = helpViewModelFactory;
            this.loginViewModelFactory = loginViewModelFactory;
        }

        public IViewModelBase CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Home:
                    return this.homeViewModelFactory.CreateViewModel();
                case ViewType.TrackGame:
                    return this.trackGameViewModelFactory.CreateViewModel();
                case ViewType.ViewStats:
                    return this.viewStatsViewModelFactory.CreateViewModel();
                case ViewType.Configuration:
                    return this.configurationViewModelFactory.CreateViewModel();
                case ViewType.Profile:
                    return this.profileViewModelFactory.CreateViewModel();
                case ViewType.Help:
                    return this.helpViewModelFactory.CreateViewModel();
                case ViewType.Login:
                    return this.loginViewModelFactory.CreateViewModel();
                default:
                    throw new ArgumentException("The ViewModel doesn't have a ViewModel", "viewType");
            }
        }
    }
}
