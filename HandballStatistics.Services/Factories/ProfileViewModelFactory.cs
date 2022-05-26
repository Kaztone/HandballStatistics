using HandballStatistics.Interfaces.ViewModels;
using HandballStatistics.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandballStatistics.Services.Factories
{
    public class ProfileViewModelFactory : IViewModelFactory<ProfileViewModel>
    {
        public ProfileViewModel CreateViewModel()
        {
            return new ProfileViewModel();
        }
    }
}
