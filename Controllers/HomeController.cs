using Customers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ICustomers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult CustomerForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult CustomerForm(Customer customer)
        {
            Repository.AddResponses(customer);
            return View("Thanks", customer);
        }

        public ViewResult ListReturns()
        {
            return View(Repository.Responses.Where(r => r.willubuyagain == true));
        }


    }
}
