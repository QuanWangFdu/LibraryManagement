// BookController.cs
using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Models;
using LibraryManagement.ViewModels;
using LibraryManagement.Data;
using LibraryManagement.Exceptions;

namespace LibraryManagement.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _dbContext;

        public BookController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var books = new List<BookViewModel>();
            var bookList = _dbContext.Books.ToList();
            foreach (var book in bookList)
            {
                var author = _dbContext.Authors.Find(book.AuthorId);
                var branch = _dbContext.LibraryBranches.Find(book.LibraryBranchId);
                var bookViewModel = new BookViewModel
                {
                    BookId = book.BookId,
                    Title = book.Title,
                    AuthorName = author?.Name ?? "Unknown", 
                    BranchName = branch?.BranchName ?? "Unknown"
                };
                books.Add(bookViewModel);
            }
            return View(books);
        }
        
        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Details(int id)
        {
            var book = _dbContext.Books.Find(id);
            if (book == null)
            {
                throw new BookNotFoundException(id);
            }
            
            var author = _dbContext.Authors.Find(book.AuthorId);
            var branch = _dbContext.LibraryBranches.Find(book.LibraryBranchId);

            var bookViewModel = new BookViewModel
            {
                BookId = book.BookId,
                Title = book.Title,
                AuthorName = author?.Name ?? "Unknown", 
                BranchName = branch?.BranchName ?? "Unknown"
            };

            return View(bookViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult EditForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditForm(int id)
        {
            var book = _dbContext.Books.Find(id);
            if (book == null)
            {
                return View(); 
            }
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Update(book);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        [HttpGet]
        public IActionResult DeleteForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteForm(int id)
        {
            var book = _dbContext.Books.Find(id);
            if (book == null)
            {
                return View(); 
            }
            return View(book);
        }

        [HttpPost, ActionName("DeleteConfirmed")]
        public IActionResult DeleteConfirmed(int BookId)
        {
            var book = _dbContext.Books.Find(BookId);
            if (book != null)
            {
                _dbContext.Books.Remove(book);
                _dbContext.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}