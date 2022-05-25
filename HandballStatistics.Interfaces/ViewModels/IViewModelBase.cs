using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandballStatistics.Interfaces.ViewModels
{
    public interface IViewModelBase : INotifyPropertyChanged
    {
        new event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName);
        
    }
}
