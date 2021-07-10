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
        private readonly ApplicationDbContext db = new ApplicationDbContext();
        private readonly ILogger<AuthorController> _logger;

        public DoctorController(ILogger<AuthorController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
           /*  Doctor objDoctor = new Doctor();

            using (var objDBContext = new DatabaseContext())
            {
                objDBContext.Doctors.Add(objDoctor);
                objDBContext.SaveChanges();
            } */


            /* Include loads the model and its relashionships
            (Doctors + its Specialty + its city */
            var doctors = db.Doctors.Include(m => m.City)
            .Include(m => m.Specialty).ToList();
            return View(doctors);
        }
    }
}
