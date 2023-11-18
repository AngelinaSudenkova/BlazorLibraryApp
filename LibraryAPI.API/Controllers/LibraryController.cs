using Microsoft.AspNetCore.Mvc;
using AccuWeatherSolution.Models;
using AccuWeatherSolution.Services;
using AccuWeatherSolution;
using LibraryAPI.API.Data;
using System.Windows.Markup;
using LibraryAPI.API.Service;



namespace LibraryAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : Controller
    {
        private readonly ILibraryService _service;

        public LibraryController(ILibraryService service)
        {
            _service = service;
        }


        //Create
        [HttpPost("Create")]
        public async Task<ActionResult<ServiceResponse<Book>>> Create([FromBody] Book book)
        {

            var result = await _service.CreateBookAsync(book);
            if (result.Success)
                return Ok(result);
            else
                return StatusCode(500, $"Internal server error {result.Message}");

        }

        //Edit
        [HttpPut("Edit")]
        public async Task<ActionResult<ServiceResponse<Book>>> Edit([FromBody] Book book)
        {
            var result = await _service.EditBookAsync(book);

            if (result.Success)
                return Ok(result);
            else
                return NotFound(result);
        }


        //Get?id=1
        [HttpGet("Get")]
        public async Task<ActionResult<ServiceResponse<Book>>> Get([FromQuery] int id)
        {
            var result = await _service.GetBookAsync(id);
            if (result.Success)
                return Ok(result);
            else
                return NotFound(result);


        }


        //GetAll
        [HttpGet("GetAllBooks")]
        public async Task<ActionResult<ServiceResponse<List<Book>>>> GetAll()
        {
            var result = await _service.GetAllBooksAsync();
            if (result.Success)
                return Ok(result);
            else
                return StatusCode(500, $"Internal server error {result.Message}");

        }

        //Delete 
        [HttpDelete("Delete")]
        public async Task<ActionResult<ServiceResponse<bool>>> Delete([FromQuery] int id)
        {
            var result = await _service.DeleteBookAsync(id);
            if (result.Success)
                return Ok(result);
            else
                return NotFound(result);

        }



        [HttpGet("search/{text}/{page}/{pageSize}")]
        [HttpGet("search/{page}/{pageSize}")]
        public async Task<ActionResult<ServiceResponse<List<Book>>>> SearchBooks(string? text = null, int page = 1, int pageSize = 10)
        {

            var result = await _service.SearchBooksAsync(text, page, pageSize);

            if (result.Success)
                return Ok(result);
            else
                return StatusCode(500, $"Internal server error {result.Message}");
        }



    }
}
