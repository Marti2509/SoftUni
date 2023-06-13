using Library.Core.Contracts;
using Library.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BookController : BaseController
    {
        private readonly IBookService bookService;

        public BookController(IBookService _bookService)
        {
            bookService = _bookService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var books = await bookService.GetAllBooksAsync();

            return View(books);
        }

        [HttpGet]
        public async Task<IActionResult> Mine()
        {
            var books = await bookService.GetMyBooksAsync(GetUserId());

            return View(books);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var bookModel = await bookService.GetNewBookFormModelAsync();

            return View(bookModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddBookFormModel model)
        {
            decimal rating;

            if (!decimal.TryParse(model.Rating, out rating) || rating < 0 || rating > 10)
            {
                ModelState.AddModelError(nameof(model.Rating), "The ratinig must be between 0 and 10!");

                return View(model);
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await bookService.AddBookAsync(model);

            return RedirectToAction("All");
        }

        public async Task<IActionResult> AddToCollection(int id)
        {
            var book = await bookService.GetBookByIdAsync(id);

            if (book == null)
            {
                return RedirectToAction("All");
            }

            var userId = GetUserId();

            await bookService.AddToCollectionAsync(userId, book);

            return RedirectToAction("All");
        }

        public async Task<IActionResult> RemoveFromCollection(int id)
        {
            var book = await bookService.GetBookByIdAsync(id);

            if (book == null)
            {
                return RedirectToAction("All");
            }

            var userId = GetUserId();

            await bookService.RemoveFromCollectionAsync(userId, book);

            return RedirectToAction("Mine");
        }
    }
}
