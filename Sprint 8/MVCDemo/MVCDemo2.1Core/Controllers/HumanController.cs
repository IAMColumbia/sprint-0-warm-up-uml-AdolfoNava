using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCDemo2._1Core.Models;


namespace MVCDemo2._1Core.Controllers
{
    public class HumanController : Controller
    {
        List<IHuman> humans;
       public HumanController()
        {
            humans = new List<IHuman>()
            {
                new Character(),
                new Bandit()
            };
        }
        // GET: Human
        public ActionResult Index()
        {
            return View(humans);
        }

        // GET: Human/Details/5
        public ActionResult Details(string name)
        {
            return View(humans.Where(n=>n.Name==name).FirstOrDefault());
        }

        // GET: Human/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Human/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Human/Edit/5
        public ActionResult Edit(int id)
        {
            return View(humans[id]);
        }

        // POST: Human/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Human/Delete/5
        public ActionResult Delete(string name)
        {
            return View(humans.Where(n => n.Name == name).FirstOrDefault());
        }

        // POST: Human/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}