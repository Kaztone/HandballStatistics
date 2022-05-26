using HandballStatistics.Interfaces.Services;
using HandballStatistics.Interfaces.ViewModels;
using HandballStatistics.Models;
using HandballStatistics.ViewModels;

namespace HandballStatistics.Services.Factories
{
    public class TrackGameViewModelFactory : IViewModelFactory<TrackGameViewModel>
    {
        private readonly IDataService<Country> countryDataService;

        private readonly IDataService<League> leagueDataService;

        private readonly IDataService<Hall> hallDataService;

        private readonly IDataService<Team> teamDataService;

        public TrackGameViewModelFactory(
            IDataService<Country> countryDataService, 
            IDataService<League> leagueDataService, 
            IDataService<Hall> hallDataService, 
            IDataService<Team> teamDataService)
        {
            this.countryDataService = countryDataService;
            this.leagueDataService = leagueDataService;
            this.hallDataService = hallDataService;
            this.teamDataService = teamDataService;
        }

        public TrackGameViewModel CreateViewModel()
        {
            return new TrackGameViewModel(
                this.countryDataService,
                this.leagueDataService,
                this.hallDataService,
                this.teamDataService);
        }
    }
}
