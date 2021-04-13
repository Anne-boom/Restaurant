using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
    public class Gebruiker : Controller
    {
        // GET: Gebruiker
        public ActionResult Index()
        {
            return View();
        }

        // GET: Gebruiker/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Gebruiker/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gebruiker/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Gebruiker/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Gebruiker/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Gebruiker/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Gebruiker/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
