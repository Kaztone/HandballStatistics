using HandballStatistics.Commands;
using HandballStatistics.Interfaces.Navigators;
using HandballStatistics.Interfaces.ViewModels;
using HandballStatistics.Models;
using System.Windows.Input;

namespace HandballStatistics.Services.Navigators
{
    public class Navigator : ObservableObject, INavigator
    {
        private IViewModelBase currentViewModel;

        public IViewModelBase CurrentViewModel
        {
            get => this.currentViewModel;
            set
            {
                this.currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }
    }
}
