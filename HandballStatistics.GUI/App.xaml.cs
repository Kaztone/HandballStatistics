using HandballStatistics.EntityFramework.Contexts;
using HandballStatistics.Interfaces.Authenticators;
using HandballStatistics.Interfaces.Navigators;
using HandballStatistics.Interfaces.Services;
using HandballStatistics.Interfaces.ViewModels;
using HandballStatistics.Models;
using HandballStatistics.Services.AuthenticationServices;
using HandballStatistics.Services.DbServices;
using HandballStatistics.Services.Factories;
using HandballStatistics.Services.Navigators;
using HandballStatistics.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace HandballStatistics.GUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IServiceProvider serviceProvider = CreateServiceProvider();

            Window window = new MainWindow();
            window.DataContext = serviceProvider.GetRequiredService<MainViewModel>();
            window.Show();

            base.OnStartup(e);
        }

        private IServiceProvider CreateServiceProvider()
        {
            IServiceCollection services = new ServiceCollection();

            // Implemented services
            services.AddSingleton<HandballStatisticsDbContext>();
            services.AddSingleton<IAuthenticationService, AuthenticationService>();
            services.AddSingleton<IDataService<Account>, AccountDataService>();
            services.AddSingleton<IDataService<Country>, GenericDataService<Country>>();
            services.AddSingleton<IDataService<League>, GenericDataService<League>>();
            services.AddSingleton<IDataService<Hall>, GenericDataService<Hall>>();
            services.AddSingleton<IDataService<Team>, GenericDataService<Team>>();
            services.AddSingleton<IAccountDataService, AccountDataService>();

            // ViewModels as services
            services.AddSingleton<IViewModelAbstractFactory, ViewModelAbstractFactory>();
            services.AddSingleton<IViewModelFactory<HomeViewModel>, HomeViewModelFactory>();
            services.AddSingleton<IViewModelFactory<TrackGameViewModel>, TrackGameViewModelFactory>();
            services.AddSingleton<IViewModelFactory<ViewStatsViewModel>, ViewStatsViewModelFactory>();
            services.AddSingleton<IViewModelFactory<ConfigurationViewModel>, ConfigurationViewModelFactory>();
            services.AddSingleton<IViewModelFactory<ProfileViewModel>, ProfileViewModelFactory>();
            services.AddSingleton<IViewModelFactory<HelpViewModel>, HelpViewModelFactory>();

            services.AddSingleton<IViewModelFactory<LoginViewModel>>((s) => 
                new LoginViewModelFactory(s.GetRequiredService<IAuthenticator>(), 
                new ViewModelFactoryRenavigator<HomeViewModel>(s.GetRequiredService<INavigator>(),
                s.GetRequiredService<IViewModelFactory<HomeViewModel>>())));

            // Single instance services
            services.AddScoped<IAuthenticator, Authenticator>();
            services.AddScoped<INavigator, Navigator>();
            services.AddScoped<MainViewModel>();

            return services.BuildServiceProvider();
        }
    }
}
