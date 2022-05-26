using HandballStatistics.Interfaces.ViewModels;
using HandballStatistics.ViewModels;

namespace HandballStatistics.Services.Factories
{
    public class HelpViewModelFactory : IViewModelFactory<HelpViewModel>
    {
        public HelpViewModel CreateViewModel()
        {
            return new HelpViewModel();
        }
    }
}
