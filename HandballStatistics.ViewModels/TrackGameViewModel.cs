using HandballStatistics.EntityFramework.Contexts;
using HandballStatistics.Interfaces.Services;
using HandballStatistics.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace HandballStatistics.ViewModels
{
    public class TrackGameViewModel : ViewModelBase
    {
        private readonly IDataService<Country> countryDataService; 

        private readonly IDataService<League> leagueDataService; 

        private readonly IDataService<Hall> hallDataService; 

        private readonly IDataService<Team> teamDataService; 

        private readonly HandballStatisticsDbContext context;

        public TrackGameViewModel(
            IDataService<Country> countryDataService, 
            IDataService<League> leagueDataService, 
            IDataService<Hall> hallDataService, 
            IDataService<Team> teamDataService)
        {
            this.countryDataService = countryDataService;
            this.leagueDataService = leagueDataService;
            this.hallDataService = hallDataService;
            this.teamDataService = teamDataService;

            LoadEntities();
        }

        public ObservableCollection<Country> Countries { get; set; }

        public ObservableCollection<League> Leagues { get; set; }

        public ObservableCollection<Hall> Halls { get; set; }

        public ObservableCollection<Team> Teams { get; set; }



        public void LoadEntities()
        {
            GetCountries();
            GetLeagues();
            GetHalls();
            GetTeams();
        }

        public async void GetCountries()
        {
            var countries = await this.countryDataService.GetAll();
            this.Countries = (ObservableCollection<Country>)countries;
        }

        public async void GetLeagues()
        {
            var leagues = await this.leagueDataService.GetAll();
            this.Leagues = (ObservableCollection<League>)leagues;
        }

        public async void GetHalls()
        {
            var halls = await this.hallDataService.GetAll();
            this.Halls = (ObservableCollection<Hall>)halls;
        }

        public async void GetTeams()
        {
            var teams = await this.teamDataService.GetAll();
            this.Teams = (ObservableCollection<Team>)teams;
        }

    }
}
