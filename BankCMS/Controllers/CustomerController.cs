using BankCMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankCMS.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var customers = new[]
        {
            new Customer { Id = 1, Name = "binjesus", Email = "binjesus@crossfi.com" },
            new Customer { Id = 2, Name = "deez knocks", Email = "deez@snoop.edu" },
            new Customer { Id = 3, Name = "deez knocks", Email = "deez@snoop.edu" },
            new Customer { Id = 4, Name = "deez knocks", Email = "deez@snoop.edu" }

        };
            return View(customers);
        }
        public IActionResult Details(int id)
        {
            var customer = new Customer { Id = id, Name = "abinessa", Email = "abinessa@sdsu.com" };
            return View(customer);
        }


    }
}
