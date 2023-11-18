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
        public Task<ServiceResponse<List<Book>>> GetAllBooksAsync();
        public Task<ServiceResponse<Book>> GetBookAsync(int id);
        public Task<ServiceResponse<bool>> DeleteBookAsync(int id);
        public Task<ServiceResponse<Book>> CreateBookAsync(Book book);
        public Task<ServiceResponse<Book>> EditBookAsync(Book book);
        Task<ServiceResponse<List<Book>>> SearchBooksAsync(string text, int page, int pageSize);
    }


}


