using HandballStatistics.Interfaces.ViewModels;
using System.Windows.Input;

namespace HandballStatistics.Interfaces.Navigators
{
    public enum ViewType
    {
        Login,
        Home,
        TrackGame,
        ViewStats,
        AddData,
        AddTeam,
        DeleteTeam,
        AddPlayer,
        DeletePlayer,
        Profile,
        Help
    }

    public interface INavigator
    {
        IViewModelBase CurrentViewModel { get; set; }

        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
