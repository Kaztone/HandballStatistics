using HandballStatistics.Interfaces.ViewModels;
using HandballStatistics.ViewModels;

namespace HandballStatistics.Services.Factories
{
    public class ConfigurationViewModelFactory : IViewModelFactory<ConfigurationViewModel>
    {
        public ConfigurationViewModel CreateViewModel()
        {
            return new ConfigurationViewModel();
        }
    }
}
