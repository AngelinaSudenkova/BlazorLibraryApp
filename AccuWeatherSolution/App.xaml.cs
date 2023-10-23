using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AccuWeatherSolution.Services;
using AccuWeatherSolution.ViewModels;




namespace AccuWeatherSolution
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        IServiceProvider _serviceProvider;

        public App()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();

        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IService, Service>();
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<ActivityFunViewModel>();
            services.AddSingleton<ForecastViewModel>();
            services.AddSingleton<GeopositionClassViewModel>();
            services.AddSingleton<HistoricalViewModel>();
            services.AddSingleton<NeighboursViewModel>();
            services.AddTransient<MainWindow>();

        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
