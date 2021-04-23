using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo2._1Core.Controllers
{
    public class IntroController : Controller
{
    public IActionResult Index(string name)
    {
            ViewData["Message"] = $"Hello {name} from MVC demo type in /Human for the extension of my objects in work";
        return View();
    }
    //public string Hello(string name, int ?Age=0)
    //    {
    //        return $"Hello {name} from MVC! I am {Age} years old now.";
    //    }
    //public string Hello()
    //    {
    //        return "Hello from the program";
    //    }
    //    public string Bye()
    //    {
    //        return "Goodbye onlooker see you later";
    //    }
}
}
