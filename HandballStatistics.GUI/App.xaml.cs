using HandballStatistics.Interfaces.Services;
using HandballStatistics.Models;
using HandballStatistics.Services.DbServices;
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
            window.Show();

            base.OnStartup(e);
        }

        private IServiceProvider CreateServiceProvider()
        {
            IServiceCollection services = new ServiceCollection();

            return services.BuildServiceProvider();
        }
    }
}
