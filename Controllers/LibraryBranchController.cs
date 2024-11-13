// LibraryBranchController.cs
using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Models;
using LibraryManagement.ViewModels;
using LibraryManagement.Data;

namespace LibraryManagement.Controllers
{
    public class LibraryBranchController : Controller
    {
        private readonly AppDbContext _dbContext;

        public LibraryBranchController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var librarybranches = _dbContext.LibraryBranches.ToList();
            return View(librarybranches);
        }
        
        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Details(int id)
        {
            var librarybranch = _dbContext.LibraryBranches.Find(id);
            if (librarybranch == null)
            {
                return View();
            }
            return View(librarybranch);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(LibraryBranch librarybranch)
        {
            _dbContext.LibraryBranches.Add(librarybranch);
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
            var librarybranch = _dbContext.LibraryBranches.Find(id);
            if (librarybranch == null)
            {
                return View(); 
            }
            return View(librarybranch);
        }

        [HttpPost]
        public IActionResult Edit(LibraryBranch librarybranch)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Update(librarybranch);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(librarybranch);
        }

        [HttpGet]
        public IActionResult DeleteForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteForm(int id)
        {
            var librarybranch = _dbContext.LibraryBranches.Find(id);
            if (librarybranch == null)
            {
                return View(); 
            }
            return View(librarybranch);
        }

        [HttpPost, ActionName("DeleteConfirmed")]
        public IActionResult DeleteConfirmed(int LibraryBranchId)
        {
            var librarybranch = _dbContext.LibraryBranches.Find(LibraryBranchId);
            if (librarybranch != null)
            {
                _dbContext.LibraryBranches.Remove(librarybranch);
                _dbContext.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}