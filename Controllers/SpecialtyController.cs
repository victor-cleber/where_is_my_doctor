using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using where_is_my_doctor.Models;
using Microsoft.EntityFrameworkCore;



namespace where_is_my_doctor.Controllers
{
    public class SpecialtyController : Controller
    {
        private readonly ApplicationDbContext _myDbContext;

        private readonly ILogger<DoctorController> _logger;

        public SpecialtyController(ILogger<DoctorController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _myDbContext = context;
        }

        // GET: Specialty
        public IActionResult Index(ApplicationDbContext db)
        {
            /* Include loads the model and its relashionships
            (Doctors + its Specialty + its city */
            using (var dbContext = new ApplicationDbContext())
            {
                var specialties = db.Specialties.ToList();
                return View(specialties);
            }
        }

        // GET: Specialty/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Specialty/Create        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Specialty specialty)
        {
            if (ModelState.IsValid)
            {
                _myDbContext.Add(specialty);
                await _myDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(specialty);
        }

        //GET: Specialty/Edit/5
        public async Task<IActionResult> Edit(int? id){
            if(id==null){
                return NotFound();
            }
            
            var specialty = await _myDbContext.Specialties.SingleOrDefaultAsync(m => m.SpecialtyId == id);
            
            if (specialty == null){
                return NotFound();
            }

            return View(specialty);
        }

        //POST: Specialty/Edit/6
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Specialty specialty){
            if (id != specialty.SpecialtyId){
                return NotFound();
            }
            if(ModelState.IsValid){
                try{
                    _myDbContext.Update(specialty);
                    await _myDbContext.SaveChangesAsync();

                }catch(DbUpdateConcurrencyException){
                    if(!SpecialtyExist(specialty.SpecialtyId)){
                        return NotFound();
                    }else{
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(specialty);
        }

        //POST: Doctor/Delete/12
        public async Task<IActionResult> Delete(int? id){
            if (id== null){
                return NotFound();
            }

            var specialty = await _myDbContext.Specialties
            .SingleOrDefaultAsync(m => m.SpecialtyId == id);
            if(specialty == null){
                return NotFound();
            }

            return View(specialty);
        }

        //POST: Specialty/Delete/12
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id){
            var specialty = await _myDbContext.Specialties.SingleOrDefaultAsync(m => m.SpecialtyId == id);
            _myDbContext.Specialties.Remove(specialty);
            return RedirectToAction("Index");
        }

        private bool SpecialtyExist(int id){
            return _myDbContext.Specialties.Any(e => e.SpecialtyId == id);
        }
    }
}
