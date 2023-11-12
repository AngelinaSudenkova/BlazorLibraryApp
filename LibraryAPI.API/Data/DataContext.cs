using AccuWeatherSolution.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.API.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Book>()
              .Property(b => b.Id)
              .ValueGeneratedNever();


            modelBuilder.Entity<Book>()
                 .Property(b => b.Title)
                 .IsRequired()
                 .HasMaxLength(100);

            modelBuilder.Entity<Book>()
                .Property(b => b.Author)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Book>()
                .Property(b => b.Description)
                .HasMaxLength(255);

          

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
                optionsBuilder.UseSqlServer(GetConnectionString());
        }

        private string GetConnectionString()
        {
            return "Data Source=(local);Initial Catalog=library;Integrated Security=True; Encrypt=False";
        }
    }
}
