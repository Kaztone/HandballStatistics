using System.ComponentModel;

namespace HandballStatistics.Models
{
    /// <summary>
    /// Base class for ObservableObject.
    /// Derives from <see cref="INotifyPropertyChanged"/> class.
    /// </summary>
    public class ObservableObject : INotifyPropertyChanged
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
        protected void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
