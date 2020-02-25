using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GC_Coffee_Shop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GC_Coffee_Shop.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegisrtationForm()
        {
            return View(new RegisterUser());
        }

        public IActionResult RegistrationResult(RegisterUser registerUser)
        {
            if (ModelState.IsValid)
            {
                return View(registerUser);
            }
            else
            {
                //the modelobject of type user did not match the 
                //requirements we made in our class
                return View("RegisrtationForm", registerUser);

            }
        }
    }
}