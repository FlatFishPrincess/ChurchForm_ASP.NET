using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChurchDb.Models;

namespace ChurchDb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
       
        //public async Task<IActionResult> ViewModelAsync()
        //{
        //    List<UserInfo> Users = new List<UserInfo>();
        //    Users.Add(_databasecontext.Users.ToList());
        //    var persons = await _context.Person.ToListAsync();

        //    return View();
        //}

                    
        //public async Task<ActionResult> IndexViewModel()  
        //{  
        //    List<Person> Persons = new List<Person>();
        //    Persons = await _context.Person.ToListAsync();

        //    ViewBag.Message = "Welcome to my demo!";  
        //    ViewModel mymodel = new ViewModel();  
        //    mymodel.Persons = GetPersons();  
        //    mymodel.Contacts = GetContacts();  
        //    return View(mymodel);  
        //}  

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
