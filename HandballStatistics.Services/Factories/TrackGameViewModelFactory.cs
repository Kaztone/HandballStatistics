using HandballStatistics.Interfaces.ViewModels;
using HandballStatistics.ViewModels;

namespace HandballStatistics.Services.Factories
{
    public class TrackGameViewModelFactory : IViewModelFactory<TrackGameViewModel>
    {
        public TrackGameViewModel CreateViewModel()
        {
            return new TrackGameViewModel();
        }
    }
}
