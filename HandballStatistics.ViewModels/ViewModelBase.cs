using HandballStatistics.Interfaces.ViewModels;
using System.ComponentModel;

namespace HandballStatistics.ViewModels
{
    public class ViewModelBase : IViewModelBase
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
