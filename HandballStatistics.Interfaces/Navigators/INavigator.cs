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
        Configuration,
        Profile,
        Help
    }

    public interface INavigator
    {
        IViewModelBase CurrentViewModel { get; set; }
    }
}
