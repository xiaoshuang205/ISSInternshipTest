using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EONRealityFinal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EONRealityFinal.Controllers
{
    public class SaveController : Controller
    {
        private readonly EONRealityFinal.Data.EONRealityFinalContext _context;
        public SaveController(EONRealityFinal.Data.EONRealityFinalContext context)
        {
            _context = context;
        }
        
        // GET: Save
        public ActionResult Index()
        {
            Console.WriteLine(HttpContext.Request.Form);
            User user = new User()
            {
                Name = HttpContext.Request.Form["name"],
                Email = HttpContext.Request.Form["email"],
                Gender = HttpContext.Request.Form["gender"],
                DateRegistered = Convert.ToDateTime(HttpContext.Request.Form["registeredDate"]),
                EventDays = HttpContext.Request.Form["eventDays"],
                Request = HttpContext.Request.Form["request"]
            };
            _context.Users.Add(user);
            try
            {
                _context.SaveChanges();
            }
            catch
            {
                return View();
            }
            
            return LocalRedirect("/Users");
        }

        // GET: Save/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Save/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Save/Create
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

        // GET: Save/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Save/Edit/5
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

        // GET: Save/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Save/Delete/5
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