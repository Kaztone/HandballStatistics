using HandballStatistics.EntityFramework.Contexts;
using System.Collections.ObjectModel;

namespace HandballStatistics.ViewModels
{
    public class TrackGameViewModel : ViewModelBase
    {
        private readonly HandballStatisticsDbContext context;

        public ObservableCollection<> Countries;
        public ObservableCollection<> Leagues;
        public ObservableCollection<> Halls;
        public ObservableCollection<> Teams;
    }
}
