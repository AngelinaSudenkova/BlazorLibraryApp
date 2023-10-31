using AccuWeatherSolution.Configuration;
using AccuWeatherSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Windows.Controls;
using static System.Net.WebRequestMethods;
using System.Security.Policy;
using System.Reflection.Metadata;


namespace AccuWeatherSolution.Services
{
    internal class LibraryService : ILibraryService
    {

        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;
        private readonly string Path = "https://localhost:7285/"; 

        public LibraryService(HttpClient httpClient, IOptions<AppSettings> appSettings) {
            _httpClient = httpClient;
            _appSettings = appSettings.Value;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {

            var response = await _httpClient.GetAsync(Path + _appSettings.BaseLibraryEndpoint.Base_url + _appSettings.BaseLibraryEndpoint.GetAllBooksEndpoint);
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Book>>(json);
            return result;
        }

        public async Task<HttpResponseMessage> CreateBookAsync(Book book)
        {
            var json = JsonConvert.SerializeObject(book);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(Path + _appSettings.BaseLibraryEndpoint.Base_url + _appSettings.BaseLibraryEndpoint.CreateBookEndpoint, content);
            return response;
        }


        public async Task<HttpResponseMessage> DeleteBookAsync(int id)
        {
            var response = await _httpClient.DeleteAsync(Path + _appSettings.BaseLibraryEndpoint.Base_url + _appSettings.BaseLibraryEndpoint.DeleteEndpoint + "?id="+id);
            return response;
        }

        public async Task<HttpResponseMessage> EditBookAsync(Book book)
        {
            var json = JsonConvert.SerializeObject(book);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync(Path + _appSettings.BaseLibraryEndpoint.Base_url + _appSettings.BaseLibraryEndpoint.UpdateBookEndpoint, content);

            return response;
        }

        public async Task<Book> GetBookAsync(int id)
        {
            var response = await _httpClient.GetAsync(Path + _appSettings.BaseLibraryEndpoint.Base_url + _appSettings.BaseLibraryEndpoint.GetBookEndpoint + "?id=" + id);
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Book>(json);
            return result;
        }
    }
}
