﻿using HandballStatistics.Interfaces.Services;
using HandballStatistics.Models;
using HandballStatistics.Services.DbServices;
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
            Window window = new MainWindow();
            window.Show();

            base.OnStartup(e);
        }
    }
}