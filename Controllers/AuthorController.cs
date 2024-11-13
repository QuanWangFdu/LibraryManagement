// AuthorController.cs
using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Models;
using LibraryManagement.ViewModels;
using LibraryManagement.Data;

namespace LibraryManagement.Controllers
{
    public class AuthorController : Controller
    {
        private readonly AppDbContext _dbContext;

        public AuthorController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var authors = _dbContext.Authors.ToList();
            return View(authors);
        }
        
        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Details(int id)
        {
            var author = _dbContext.Authors.Find(id);
            if (author == null)
            {
                return View();
            }
            return View(author);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Author author)
        {
            _dbContext.Authors.Add(author);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // Displays a form to input the author ID
        [HttpGet]
        public IActionResult EditForm()
        {
            return View();
        }

        // Fetches and displays the author's details for editing
        [HttpPost]
        public IActionResult EditForm(int id)
        {
            var author = _dbContext.Authors.Find(id);
            if (author == null)
            {
                return View(); 
            }
            return View(author);
        }

        // Handles the submission of the updated author details
        [HttpPost]
        public IActionResult Edit(Author author)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Update(author);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(author);
        }

        [HttpGet]
        public IActionResult DeleteForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteForm(int id)
        {
            var author = _dbContext.Authors.Find(id);
            if (author == null)
            {
                return View(); 
            }
            return View(author);
        }

        [HttpPost, ActionName("DeleteConfirmed")]
        public IActionResult DeleteConfirmed(int AuthorId)
        {
            var author = _dbContext.Authors.Find(AuthorId);
            if (author != null)
            {
                _dbContext.Authors.Remove(author);
                _dbContext.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}