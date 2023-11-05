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
using System.Net.Http.Json;

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

        public async Task<ServiceResponse<List<Book>>> GetAllBooksAsync()
        {

            var response = await _httpClient.GetAsync(Path + _appSettings.BaseLibraryEndpoint.Base_url + _appSettings.BaseLibraryEndpoint.GetAllBooksEndpoint);
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<List<Book>>>(json);
            return result;
        }

        public async Task<ServiceResponse<Book>> CreateBookAsync(Book book)
        {
            var json = JsonConvert.SerializeObject(book);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(Path + _appSettings.BaseLibraryEndpoint.Base_url + _appSettings.BaseLibraryEndpoint.CreateBookEndpoint, content);
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<Book>>();
            return result;
        }


        public async Task<ServiceResponse<bool>> DeleteBookAsync(int id)
        {
            var response = await _httpClient.DeleteAsync(Path + _appSettings.BaseLibraryEndpoint.Base_url + _appSettings.BaseLibraryEndpoint.DeleteEndpoint + "?id="+id);
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
            return result;
        }

        public async Task<ServiceResponse<Book>> EditBookAsync(Book book)
        {
            var json = JsonConvert.SerializeObject(book);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync(Path + _appSettings.BaseLibraryEndpoint.Base_url + _appSettings.BaseLibraryEndpoint.UpdateBookEndpoint, content);
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<Book>>();
            return result;
        }

        public async Task<ServiceResponse<Book>> GetBookAsync(int id)
        {
            var response = await _httpClient.GetAsync(Path + _appSettings.BaseLibraryEndpoint.Base_url + _appSettings.BaseLibraryEndpoint.GetBookEndpoint + "?id=" + id);
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<Book>>(json);
            return result;
        }

    }
}
