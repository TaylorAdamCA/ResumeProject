using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ResumeBuilder.Controllers.Resume
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        public ActionResult Index()
        {
            return View();
        }

        // GET: Experience/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Experience/Create
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

        // GET: Experience/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Experience/Edit/5
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

        // GET: Experience/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Experience/Delete/5
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