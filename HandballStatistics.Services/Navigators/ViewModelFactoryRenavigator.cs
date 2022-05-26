using HandballStatistics.Interfaces.Navigators;
using HandballStatistics.Interfaces.ViewModels;

namespace HandballStatistics.Services.Navigators
{
    public class ViewModelFactoryRenavigator<TViewModel> : IRenavigator where TViewModel : IViewModelBase
    {
        private readonly INavigator navigator;

        private readonly IViewModelFactory<TViewModel> viewModelFactory;

        public ViewModelFactoryRenavigator(INavigator navigator, IViewModelFactory<TViewModel> viewModelFactory)
        {
            this.navigator = navigator;
            this.viewModelFactory = viewModelFactory;
        }

        public void Renavigate()
        {
            this.navigator.CurrentViewModel = this.viewModelFactory.CreateViewModel();
        }
    }
}
