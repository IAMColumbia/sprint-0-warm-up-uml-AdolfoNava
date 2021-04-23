using Currency;
using Currency.US;
using Microsoft.AspNetCore.Mvc;
using MVCDemo2._1Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo2._1Core.Controllers
{
    public class CurrencyRepoController : Controller
{
        ICurrencyRepo repo { get; set; }
        RepoViewModel vm;

        public CurrencyRepoController()
        {
            repo = new USCurrencyRepo(); //can we inject this?
            vm = new RepoViewModel(repo);
            
        }

        // GET: CurrencyRepo
        public ActionResult Index()
        {
            //ViewData["Message"] = "The MVC couldn't "
            return View(vm);
        }

        // GET: CurrencyRepo
        public ActionResult MakeChange(decimal TotalValue)
        {
            vm.MakeChange(TotalValue);
            return View(vm);
        }
        //public ActionResult MakeChange(decimal TotalValue)
        //{
        //    vm.MakeChange(TotalValue);
        //    return View(vm);
        //}
    }
}
