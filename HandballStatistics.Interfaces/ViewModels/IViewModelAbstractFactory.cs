using HandballStatistics.Interfaces.Navigators;

namespace HandballStatistics.Interfaces.ViewModels
{
    public interface IViewModelAbstractFactory
    {
        IViewModelBase CreateViewModel(ViewType viewType);
    }
}
