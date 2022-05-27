using HandballStatistics.Interfaces.Services;
using HandballStatistics.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace HandballStatistics.ViewModels
{
    /// <summary>
    /// Base class for TrackGameViewModel.
    /// Derives from <see cref="ViewModelBase"/> class.
    /// </summary>
    public class TrackGameViewModel : ViewModelBase
    {
        #region-----------------------------Fields---------------------------------------------
        /// <summary>
        /// Private Field for countryDataService.
        /// </summary>
        private readonly IDataService<Country> countryDataService;

        /// <summary>
        /// Private Field for leagueDataService.
        /// </summary>
        private readonly IDataService<League> leagueDataService;

        /// <summary>
        /// Private Field for hallDataService.
        /// </summary>
        private readonly IDataService<Hall> hallDataService;

        /// <summary>
        /// Private Field for teamDataService.
        /// </summary>
        private readonly IDataService<Team> teamDataService;
        #endregion

        #region-----------------------------Constructor,Destrucor,Dispose,Clone----------------       
        /// <summary>
        /// Prevents a default instance of the <see cref="TrackGameViewModel"/> class from being created.
        /// Initializes a new instance of the <see cref="HandballStatistics.ViewModels.TrackGameViewModel" /> class. 
        /// </summary>
        /// <param name="countryDataService">Registered IDataService countryDataService.</param>
        /// <param name="leagueDataService">Registered IDataService leagueDataService.</param>
        /// <param name="hallDataService">Registered IDataService hallDataService.</param>
        /// <param name="teamDataService">Registered IDataService teamDataService.</param>
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

            this.LoadEntities();
        }
        #endregion

        #region-----------------------------Properties, Indexer--------------------------------
        /// <summary>
        /// Gets or sets Countries.
        /// </summary>
        public ObservableCollection<Country> Countries { get; set; }

        /// <summary>
        /// Gets or sets Leagues.
        /// </summary>
        public ObservableCollection<League> Leagues { get; set; }

        /// <summary>
        /// Gets or sets Halls.
        /// </summary>
        public ObservableCollection<Hall> Halls { get; set; }

        /// <summary>
        /// Gets or sets Teams.
        /// </summary>
        public ObservableCollection<Team> Teams { get; set; }
        #endregion

        #region-----------------------------Comands--------------------------------------------
        /// <summary>
        /// Gets NewGameCommand.
        /// </summary>
        public ICommand NewGameCommand { get; }
        #endregion

        #region-----------------------------Methods--------------------------------------------
        /// <summary>
        /// Loads all needed entities.
        /// </summary>
        public void LoadEntities()
        {
           this.GetCountries();
           this.GetLeagues();
           this.GetHalls();
           this.GetTeams();
        }

        /// <summary>
        /// Fills ObservableCollection Countries.
        /// </summary>
        public async void GetCountries()
        {
            var countries = await this.countryDataService.GetAll();
            this.Countries = new ObservableCollection<Country>(countries);
        }

        /// <summary>
        /// Fills ObservableCollection Leagues.
        /// </summary>
        public async void GetLeagues()
        {
            var leagues = await this.leagueDataService.GetAll();
            this.Leagues = new ObservableCollection<League>(leagues);
        }

        /// <summary>
        /// Fills ObservableCollection Halls.
        /// </summary>
        public async void GetHalls()
        {
            var halls = await this.hallDataService.GetAll();
            this.Halls = new ObservableCollection<Hall>(halls);
        }

        /// <summary>
        /// Fills ObservableCollection Teams.
        /// </summary>
        public async void GetTeams()
        {
            var teams = await this.teamDataService.GetAll();
            this.Teams = new ObservableCollection<Team>(teams);
        }
        #endregion
    }
}
