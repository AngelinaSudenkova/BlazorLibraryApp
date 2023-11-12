using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AccuWeatherSolution;
using System.Collections.ObjectModel;
using AccuWeatherSolution.Services;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using AccuWeatherSolution.Models;
using Microsoft.Extensions.DependencyInjection;


namespace AccuWeatherSolution.ViewModels
{
   public partial class MainViewModel : ObservableObject
    {
        private CityViewModel _selectedCity;
       
        private IService _Service;
        private readonly IServiceProvider _serviceProvider;
        private Forecast _forecast;
        private GeopositionClass _geoposition;
     

        public MainViewModel(IService service, IServiceProvider serviceProvider)
        {
            _Service = service;
            _serviceProvider = serviceProvider;
            Cities = new ObservableCollection<CityViewModel>();
            Neighbours = new ObservableCollection<NeighboursViewModel>();
            Historicals = new ObservableCollection<HistoricalViewModel>();
            ActivitiesFun = new ObservableCollection<ActivityFunViewModel>();
        }


        [ObservableProperty]
        public GeopositionClassViewModel geopositionView;

        [RelayCommand]
        public async void LoadGeoposition(string key)
        {
            _geoposition = await _Service.GetGeolocation(key);
            GeopositionView = new GeopositionClassViewModel(_geoposition);
        }


        [ObservableProperty]
        public ForecastViewModel forecastView;

        [RelayCommand]
        public async void LoadForecast(string key)
        {
            _forecast = await _Service.GetForecast(key);
            ForecastView = new ForecastViewModel(_forecast);
        }

        public ObservableCollection<HistoricalViewModel> Historicals { get; set; }

        [RelayCommand]
        public async void LoadHistorical(string key)
        {
            var historicals = await _Service.GetHistorical(key);
            if (Historicals != null) { Historicals.Clear(); }
            foreach (var historical in historicals)
                Historicals.Add(new HistoricalViewModel(historical));

        }

      public ObservableCollection<ActivityFunViewModel> ActivitiesFun { get; set; }

        [RelayCommand]
        public async void LoadActivities(string key)
        {
            var activities = await _Service.GetActivity(key);
            if (ActivitiesFun != null) { ActivitiesFun.Clear(); }
            foreach (var activity in activities)
                ActivitiesFun.Add(new ActivityFunViewModel(activity));

        }



        public CityViewModel SelectedCity
        {
            get { return _selectedCity; }
            set
            {
                _selectedCity = value;
                OnPropertyChanged(nameof(SelectedCity));
            }
        }

        public ObservableCollection<CityViewModel> Cities { get; set; }
        [RelayCommand]
        public async void LoadCities(string locationName)
        {
            var cities = await _Service.GetLocations(locationName);
            if (Cities != null) { Cities.Clear(); }
            foreach (var city in cities)
            Cities.Add(new CityViewModel(city));
        
        }


        public ObservableCollection<NeighboursViewModel> Neighbours { get; set; }
        [RelayCommand]
        public async void LoadNeighbours(string locationName)
        {
            var neighbours = await _Service.GetNeighbours(locationName);
            if (Neighbours != null) { Neighbours.Clear(); }
            foreach (var neighbour in neighbours)
                Neighbours.Add(new NeighboursViewModel(neighbour));

        }

        [RelayCommand]
        public void OpenLibraryWindow()
        {
            LibraryWindow libraryView = _serviceProvider.GetService<LibraryWindow>();
            libraryView.Show();
        }

    }

}
