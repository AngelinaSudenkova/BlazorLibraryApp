using Microsoft.AspNetCore.Mvc;
using AccuWeatherSolution.Models;
using AccuWeatherSolution.Services;
using AccuWeatherSolution;
using LibraryAPI.API.Data;
using System.Windows.Markup;


namespace LibraryAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : Controller
    {
        private readonly ApiContext _context;

        public LibraryController(ApiContext context)
        {
            _context = context;
        }


        //Create
        [HttpPost("Create")]
        public IActionResult Create([FromBody] Book book)
        {
            var bookInDb = _context.Books.Find(book.Id);
            if (bookInDb == null)
            {
                _context.Books.Add(book);
                _context.SaveChanges();
                return Ok(book);
            }
            else
            {
                return BadRequest("This book already exists in your library");
            }
        }

        //Edit
        [HttpPut("Edit")]
        public IActionResult Edit([FromBody] Book book)
        {
            
                var bookInDb = _context.Books.Find(book.Id);
                if (bookInDb == null)
                {
                    return NotFound("There is no book to be changed");
                }

                bookInDb.Title = book.Title;
                bookInDb.Author = book.Author;
                bookInDb.Description = book.Description;
               _context.SaveChanges();
                return Ok(book);
            
        }


        //Get?id=1
        [HttpGet("Get")]
        public IActionResult Get([FromQuery] int id)
        {
            var result = _context.Books.Find(id);

            if ( result == null) { return NotFound(result); }

        return Ok(result);
        }


        //GetAll
        [HttpGet("GetAllBooks")]
        public IActionResult GetAll()
        {
            var result = _context.Books.ToList();
            return Ok(result);
        }

        //Delete 
        [HttpDelete("Delete")] public IActionResult Delete([FromQuery] int id)
        {
            var result = _context.Books.Find(id);
            if (result == null) { return NotFound(result); }

            _context.Books.Remove(result);
            _context.SaveChanges();

            return NoContent();

        }

    }
}
