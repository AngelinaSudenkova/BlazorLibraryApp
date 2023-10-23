using AccuWeatherSolution.Models;
using AccuWeatherSolution.Services;
using AccuWeatherSolution.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AccuWeatherSolution
{

    public partial class MainWindow : Window
    {
        private readonly MainViewModel _viewModel;

        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = _viewModel;
        }



        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = string.Empty; 
        }

        //private async void btnSearch_Click(object sender, RoutedEventArgs e)
        //{
        //    City[] cities = await service.GetLocations(txtCity.Text);
        //    //lbData.Items.Clear();
        //    //foreach (var c in cities)
        //    //    lbData.Items.Add(c.LocalizedName);
        //    lbData.ItemsSource = cities;
        //}

        //private void lbData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var selectedCity = (City) lbData.SelectedItem;
        //    if (selectedCity != null)
        //    {
        //        infoLabel.Content = "";
        //        chosenCity.Content = "You've chosen the city:" + selectedCity.LocalizedName;
        //        neibghourButton.Visibility = Visibility.Visible; 
        //        forecastButton.Visibility = Visibility.Visible;
        //        geopositionButton.Visibility = Visibility.Visible;
        //        historicalButton.Visibility = Visibility.Visible;
        //        linkButton.Visibility = Visibility.Visible;
        //    }
        //}

        //private async void neibghourButton_Click(object sender, RoutedEventArgs e)
        //{
        //    infoLabel.Content = "";
        //    var selectedCity = (City)lbData.SelectedItem;
        //    CityInfo.Information[] cities = await service.GetNeighbours(selectedCity.Key);
        //    infoLabel.Content = "Neighbours: ";
        //    foreach (CityInfo.Information city in cities)
        //    {
        //                infoLabel.Content += city.LocalizedName + "\n";           

        //    }
        //}

        //private async void forecastButton_Click(object sender, RoutedEventArgs e)
        //{
        //    infoLabel.Content = "";
        //    var selectedCity = (City)lbData.SelectedItem;
        //    Forecast forecast = await service.GetForecast(selectedCity.Key);
        //    infoLabel.Content = "Forecast: \n ";
        //    infoLabel.Content += "Severity level: " + forecast.Headline.Severity + "\n";
        //    infoLabel.Content += forecast.Headline.Text + "\n";
        //    infoLabel.Content += "Max temperatura: " + forecast.DailyForecasts[0].Temperature.Maximum.Value + forecast.DailyForecasts[0].Temperature.Maximum.Unit + "\n";
        //    infoLabel.Content += "Min temperatura: " + forecast.DailyForecasts[0].Temperature.Minimum.Value + forecast.DailyForecasts[0].Temperature.Minimum.Unit + "\n"; 


        //}

        //private async void geopositionButton_Click(object sender, RoutedEventArgs e)
        //{
        //    infoLabel.Content = "";
        //    var selectedCity = (City)lbData.SelectedItem;
        //    GeopositionClass geoposition = await service.GetGeolocation(selectedCity.Key);
        //    infoLabel.Content = "Longtitude: " + geoposition.GeoPosition.Longitude +" \n ";
        //    infoLabel.Content += "Latitude: " + geoposition.GeoPosition.Latitude + " \n ";
        //}

        //private async void historicalButton_Click(object sender, RoutedEventArgs e)
        //{
        //    infoLabel.Content = "";
        //    var selectedCity = (City)lbData.SelectedItem;
        //    Historical[] historical = await service.GetHistorical(selectedCity.Key);
        //    infoLabel.Content = "How did it feel lately: \n ";
        //    foreach (Historical facts in historical)
        //    {
        //        infoLabel.Content += facts.WeatherText + "\n";

        //    }
        //}

        //private async void linkButton_Click(object sender, RoutedEventArgs e)
        //{
        //    infoLabel.Content = "";
        //    var selectedCity = (City)lbData.SelectedItem;
        //    ActivityFun[] activities = await service.GetActivity(selectedCity.Key);
        //    foreach (ActivityFun activity in activities)
        //    {
        //        infoLabel.Content += activity.Name + "\n";
        //        infoLabel.Content += "Value: " + activity.Value + "\n";
        //        infoLabel.Content += "\n";

        //    }
        //}
    }
}
