using HandballStatistics.Interfaces.ViewModels;
using System.ComponentModel;

namespace HandballStatistics.ViewModels
{
    /// <summary>
    /// Base class for ViewModelBase.
    /// Derives from <see cref="IViewModelBase"/> class.
    /// </summary>
    public class ViewModelBase : IViewModelBase
    {
        #region-----------------------------Events---------------------------------------------
        /// <summary>
        /// Occurs when <see cref="OnPropertyChanged(string)"/> is raised. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion      

        #region-----------------------------Methods--------------------------------------------
        /// <summary>
        /// Raises <see cref="PropertyChanged"/> event.
        /// </summary>
        /// <param name="propertyName">String value of property name.</param>
        public void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion       
    }
}
