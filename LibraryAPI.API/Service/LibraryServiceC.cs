using AccuWeatherSolution;
using AccuWeatherSolution.Models;
using AccuWeatherSolution.Services;
using LibraryAPI.API.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.API.Service
{
    public class LibraryServiceC : ILibraryService
    {

        private readonly DataContext _dataContext;

        public LibraryServiceC(DataContext dataContext) {
            _dataContext = dataContext;
        }

        public async Task<ServiceResponse<Book>> CreateBookAsync(Book book)
        {

            try
            {
                var bookInDb = await _dataContext.Books.FindAsync(book.Id);
                if (bookInDb == null)
                {
                    _dataContext.Books.Add(book);
                    await _dataContext.SaveChangesAsync();
                    return new ServiceResponse<Book>() { Data = book, Success = true, Message = "successfully created"};
                }
                else
                {
                    return new ServiceResponse<Book>()
                    {
                        Data = null,
                        Success = false,
                        Message = "Cannot add book to a library"
                    };
                }
            }
            catch (Exception)
            {
                return new ServiceResponse<Book>()
                {
                    Data = null,
                    Success = false,
                    Message = "Cannot add book to a library"
                };
            }
        }
    

        public async Task<ServiceResponse<bool>> DeleteBookAsync(int id)
        {
            var result = _dataContext.Books.Find(id);
            if (result == null) {
                return new ServiceResponse<bool>()
                {
                    Data = false,
                    Success = false,
                    Message = "This book doesn't exist"
                };
            }

            _dataContext.Books.Remove(result);
            await _dataContext.SaveChangesAsync();

            return new ServiceResponse<bool> () { Data = true, Success = true, Message = "The book was successfully deleted" };
        }

        public async Task<ServiceResponse<Book>> EditBookAsync(Book book)
        {
            var bookInDb = _dataContext.Books.Find(book.Id);
            if (bookInDb == null)
            {
                return new ServiceResponse<Book>()
                {
                    Data = null,
                    Success = false,
                    Message = "There is no book to be updated"
                };
            }

            bookInDb.Title = book.Title;
            bookInDb.Author = book.Author;
            bookInDb.Description = book.Description;
            await _dataContext.SaveChangesAsync();
            return new ServiceResponse<Book>() {Data = book, Success = true, Message = "Successfully updated the book" };
        }

        public async Task<ServiceResponse<List<Book>>> GetAllBooksAsync()
        {
            var result = _dataContext.Books.ToList();
            try
            {
                var response = new ServiceResponse<List<Book>>()
                {
                    Data = result,
                    Message = "Ok, bye",
                    Success = true
                };

                return response;
            }
            catch (Exception)
            {
                return new ServiceResponse<List<Book>>()
                {
                    Data = null,
                    Message = "Problem with database",
                    Success = false
                };
            }
        }

        public async Task<ServiceResponse<Book>> GetBookAsync(int id)
        {
            var result = await _dataContext.Books.FindAsync(id);

            if (result == null)
            {
                return new ServiceResponse<Book>()
                {
                    Data = null,
                    Success = false,
                    Message = "This book doesn't exist"
                };
            }else
            {
                return new ServiceResponse<Book>() { Data = result, Success = true, Message = "Successfully found a book" };
            }
        }
    }
}
