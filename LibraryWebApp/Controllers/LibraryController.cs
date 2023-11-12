using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AccuWeatherSolution.Models;
using LibraryAPI.API.Data;
using AccuWeatherSolution.Services;
using X.PagedList.Mvc;
using X.PagedList;

namespace LibraryWebApp.Controllers
{

    public class LibraryController : Controller
    {
        private readonly ILibraryService _libraryService;

        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        // GET: Library
        public async Task<IActionResult> Index(int? i)
        {

            var books = await _libraryService.GetAllBooksAsync();

            return books != null ?
                        View(books.Data.AsEnumerable().ToPagedList(i ?? 1, 3)) :
                        Problem("Entity set 'DataContext.Books'  is null.");
        }

        // GET: Library/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _libraryService.GetBookAsync(id);
            if (book.Data == null)
            {
                return NotFound();
            }

            return View(book.Data);
        }

        // GET: Library/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Library/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Author,Description")] Book book)
        {
            if (ModelState.IsValid)
            {
                await _libraryService.CreateBookAsync(book);
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        // GET: Library/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _libraryService.GetBookAsync((int)id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book.Data);
        }

        // POST: Library/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Author,Description")] Book book)
        {
            if (id != book.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _libraryService.EditBookAsync(book);
                }
                catch (Exception)
                {
                    return NotFound();

                }
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        // GET: Library/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _libraryService.GetBookAsync((int)id);

            if (book == null)
            {
                return NotFound();
            }

            return View(book.Data);
        }

        // POST: Library/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _libraryService.DeleteBookAsync((int)id);
            if (product.Success)
                return RedirectToAction(nameof(Index));
            else
                return NotFound();
        }


    }
}
