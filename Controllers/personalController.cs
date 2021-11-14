using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using firstapp.Models;

namespace firstapp.Controllers
{
    public class PersonalController : Controller
    {
      public IActionResult Index()
    { 
        Personal personal = new Personal();
        personal.name = "freddie";
        personal.lastname = "Mercurie";
        personal.age =45;
        personal.phone =5550203;
        personal.email = "eooFredi@gmail.com" ;


        return View(personal);
    }

    }
}