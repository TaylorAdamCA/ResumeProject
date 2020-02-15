using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ResumeBuilder.Data;
using ResumeBuilder.lib.Entities;

namespace ResumeBuilder.Controllers
{
    public class PersonalProfilesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PersonalProfilesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PersonalProfiles
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonalProfiles.ToListAsync());
        }

        // GET: PersonalProfiles/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalProfile = await _context.PersonalProfiles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personalProfile == null)
            {
                return NotFound();
            }

            return View(personalProfile);
        }

        // GET: PersonalProfiles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonalProfiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,PhoneNumber,EmailAddress,Address,Country,CountryCode,PostalCode,Id,ContextId,DateCreated,DateUpdated")] PersonalProfile personalProfile)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personalProfile);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personalProfile);
        }

        // GET: PersonalProfiles/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalProfile = await _context.PersonalProfiles.FindAsync(id);
            if (personalProfile == null)
            {
                return NotFound();
            }
            return View(personalProfile);
        }

        // POST: PersonalProfiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("FirstName,LastName,PhoneNumber,EmailAddress,Address,Country,CountryCode,PostalCode,Id,ContextId,DateCreated,DateUpdated")] PersonalProfile personalProfile)
        {
            if (id != personalProfile.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personalProfile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonalProfileExists(personalProfile.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(personalProfile);
        }

        // GET: PersonalProfiles/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalProfile = await _context.PersonalProfiles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personalProfile == null)
            {
                return NotFound();
            }

            return View(personalProfile);
        }

        // POST: PersonalProfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var personalProfile = await _context.PersonalProfiles.FindAsync(id);
            _context.PersonalProfiles.Remove(personalProfile);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonalProfileExists(string id)
        {
            return _context.PersonalProfiles.Any(e => e.Id == id);
        }
    }
}
