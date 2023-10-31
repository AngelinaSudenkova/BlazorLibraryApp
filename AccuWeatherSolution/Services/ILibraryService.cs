using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AccuWeatherSolution.Models;

namespace AccuWeatherSolution.Services
{
    public interface ILibraryService
    {
        public Task<List<Book>> GetAllBooksAsync();
        public Task<Book> GetBookAsync(int id);
        public Task<HttpResponseMessage> DeleteBookAsync(int id);
        public Task<HttpResponseMessage> CreateBookAsync(Book book);
        public Task<HttpResponseMessage> EditBookAsync(Book book);
        

    }
}

