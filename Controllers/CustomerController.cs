// CustomerController.cs
using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Models;
using LibraryManagement.ViewModels;
using LibraryManagement.Data;

namespace LibraryManagement.Controllers
{
    public class CustomerController : Controller
    {
        private readonly AppDbContext _dbContext;

        public CustomerController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var customers = _dbContext.Customers.ToList();
            return View(customers);
        }
        
        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Details(int id)
        {
            var customer = _dbContext.Customers.Find(id);
            if (customer == null)
            {
                return View();
            }
            return View(customer);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            _dbContext.Customers.Add(customer);
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
            var customer = _dbContext.Customers.Find(id);
            if (customer == null)
            {
                return View(); 
            }
            return View(customer);
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Update(customer);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        [HttpGet]
        public IActionResult DeleteForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteForm(int id)
        {
            var customer = _dbContext.Customers.Find(id);
            if (customer == null)
            {
                return View(); 
            }
            return View(customer);
        }

        [HttpPost, ActionName("DeleteConfirmed")]
        public IActionResult DeleteConfirmed(int CustomerId)
        {
            var customer = _dbContext.Customers.Find(CustomerId);
            if (customer != null)
            {
                _dbContext.Customers.Remove(customer);
                _dbContext.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}