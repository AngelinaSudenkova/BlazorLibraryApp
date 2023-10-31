using AccuWeatherSolution.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.API.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { 
        
        }
    }
}
