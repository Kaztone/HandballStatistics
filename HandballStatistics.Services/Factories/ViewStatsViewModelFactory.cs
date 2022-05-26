using HandballStatistics.Interfaces.ViewModels;
using HandballStatistics.ViewModels;

namespace HandballStatistics.Services.Factories
{
    public class ViewStatsViewModelFactory : IViewModelFactory<ViewStatsViewModel>
    {
        public ViewStatsViewModel CreateViewModel()
        {
            return new ViewStatsViewModel();
        }
    }
}
