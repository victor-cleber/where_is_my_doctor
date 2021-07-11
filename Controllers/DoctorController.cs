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
    public class DoctorController : Controller
    {
        private readonly ApplicationDbContext _myDbContext;

        private readonly ILogger<DoctorController> _logger;

        public DoctorController(ILogger<DoctorController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _myDbContext = context;
        }


        // GET: Doctors
        public IActionResult Index(ApplicationDbContext db)
        {
            /* Include loads the model and its relashionships
            (Doctors + its Specialty + its city */
            using (var dbContext = new ApplicationDbContext())
            {
                var doctors = db.Doctors.Include(m => m.City)
                .Include(m => m.Specialty).ToList();
                return View(doctors);
            }
        }

        // GET: Doctor/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        // POST: Doctor/Create        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Doctor doctor)
        {
            if (ModelState.IsValid)
            {

                _myDbContext.Add(doctor);
                await _myDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(doctor);
        }

        //GET: Doctor/Edit/5
        public async Task<IActionResult> Edit(int? id){
            if(id==null){
                return NotFound();
            }
            var doctor = await _myDbContext.Doctors.SingleOrDefaultAsync(m => m.DoctorID == id);
            if (doctor == null){
                return NotFound();
            }
            return View(doctor);
        }

        //POST: Doctor/Edit/6
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Doctor doctor){
            if (id != doctor.DoctorID){
                return NotFound();
            }
            if(ModelState.IsValid){
                try{
                    _myDbContext.Update(doctor);
                    await _myDbContext.SaveChangesAsync();

                }catch(DbUpdateConcurrencyException){
                    if(!DoctorExist(doctor.DoctorID)){
                        return NotFound();
                    }else{
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(doctor);

        }

        //POST: Doctor/Delete/12
        public async Task<IActionResult> Delete(int? id){
            if (id== null){
                return NotFound();
            }

            var doctor = await _myDbContext.Doctors
            .SingleOrDefaultAsync(m => m.DoctorID == id);
            if(doctor == null){
                return NotFound();
            }
            return View(doctor);
        }

        //POST: Doctor/Delete/12
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id){
            var doctor = await _myDbContext.Doctors.SingleOrDefaultAsync(m => m.DoctorID == id);
            _myDbContext.Doctors.Remove(doctor);
            return RedirectToAction("Index");            

        }

        private bool DoctorExist(int id){
            return _myDbContext.Doctors.Any(e => e.DoctorID == id);
        }

    }
}
