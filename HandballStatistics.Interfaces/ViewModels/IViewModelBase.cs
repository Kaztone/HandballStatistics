using System.ComponentModel;

namespace HandballStatistics.Interfaces.ViewModels
{
    public interface IViewModelBase : INotifyPropertyChanged
    {
        void OnPropertyChanged(string propertyName);
    }
}
