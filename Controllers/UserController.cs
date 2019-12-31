using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using FlyApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlyApp.Controllers
{
    public class UserController : Controller
    {
        //GET : Home/User
        public IActionResult AddUser()
        {
            var userContext = new DAL.flyapp_DBEntities();
            DAL.User u = new DAL.User()
            { 
                nom = "amine",
                prenom = "kilo",
                adresse = "sale",
                cin = "ae11111"
            };
            var x = userContext.User.Add(u);
            userContext.SaveChanges();
           return View(x);
        }

        public IActionResult GetUsers()
        {
            var userContext = new DAL.flyapp_DBEntities();
            IQueryable<DAL.User> List_user = userContext.Set<DAL.User>();
            List<DAL.User> u = new List<DAL.User>(List_user);
            ViewData["list_user"] = u;
            return View();

        }
    }
}
