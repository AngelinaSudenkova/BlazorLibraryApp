using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.IO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AccuWeatherSolution.Services;
using AccuWeatherSolution.ViewModels;
using Microsoft.Extensions.Http;
using AccuWeatherSolution.Configuration;




namespace AccuWeatherSolution
{
    public partial class App : Application
    {
        IServiceProvider _serviceProvider;
        IConfiguration _configuration;

        public App()
        {
            var builder = new ConfigurationBuilder()
          .AddUserSecrets<App>()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json");

            var appSettingsPath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            Console.WriteLine($"Loading appsettings.json from: {appSettingsPath}");

            _configuration = builder.Build();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();

        }
        private void ConfigureServices(IServiceCollection services)
        {
            var appSettingsSection = ConfigureAppSettings(services);
            ConfigureAppServices(services);
            ConfigureViewModels(services);
            ConfigureViews(services);
            ConfigureHttpClients(services, appSettingsSection);
        }

        private AppSettings ConfigureAppSettings(IServiceCollection services)
        {
            // pobranie appsettings z konfiguracji i zmapowanie na klase AppSettings 
            var appSettings = _configuration.GetSection(nameof(AppSettings));
            var appSettingsSection = appSettings.Get<AppSettings>();
            services.Configure<AppSettings>(appSettings);
            return appSettingsSection;
        }

  
        private void ConfigureAppServices(IServiceCollection services)
        {
            // konfiguracja serwisów 

            services.AddSingleton<IService, Service>();
            services.AddSingleton<ILibraryService, LibraryService>();
        }

        private void ConfigureViewModels(IServiceCollection services)
        {
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainLibraryViewModel>();
            services.AddSingleton<ActivityFunViewModel>();
            services.AddSingleton<ForecastViewModel>();
            services.AddSingleton<GeopositionClassViewModel>();
            services.AddSingleton<HistoricalViewModel>();
            services.AddSingleton<NeighboursViewModel>();
        }

        private void ConfigureViews(IServiceCollection services)
        {
            // konfiguracja okienek 
            services.AddTransient<MainWindow>();
            services.AddTransient<LibraryWindow>();
        }

        private void ConfigureHttpClients(IServiceCollection services, AppSettings appSettingsSection)
        {
            var uriBuilder = new UriBuilder(appSettingsSection.BaseAPIUrl)
            {
                Path = appSettingsSection.BaseLibraryEndpoint.Base_url,
            };
            //Microsoft.Extensions.Http
            services.AddHttpClient<ILibraryService, LibraryService>(client => client.BaseAddress = uriBuilder.Uri);
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
