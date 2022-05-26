using HandballStatistics.Interfaces.Navigators;
using HandballStatistics.Interfaces.ViewModels;

namespace HandballStatistics.Commands
{
    public class UpdateCurrentViewModelCommand : CommandBase
    {
        private readonly INavigator navigator;

        private readonly IViewModelAbstractFactory viewModelAbstractFactory;

        public UpdateCurrentViewModelCommand(INavigator navigator, IViewModelAbstractFactory viewModelAbstractFactory)
        {
            this.navigator = navigator;
            this.viewModelAbstractFactory = viewModelAbstractFactory;
        }

        public override void Execute(object parameter)
        {
            if (parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;

                this.navigator.CurrentViewModel = this.viewModelAbstractFactory.CreateViewModel(viewType);
            }
        }
    }
}
