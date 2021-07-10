using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using where_is_my_doctor.Models;

namespace where_is_my_doctor.Controllers
{
    public class DoctorController : Controller
    {
        private readonly ILogger<AuthorController> _logger;

        public DoctorController(ILogger<AuthorController> logger)
        {
            _logger = logger;
        }
private WhereIsMyDoctorContext db = new WhereIsMyDoctorContext();

        public IActionResult Index()
        {
            /* Include loads the model and its relashionships
            (Doctors + its Specialty + its city */
            var doctors = db.Doctors.Include(m => m.City)
            .Include(m=>m.specialty).ToList();
            return View(doctors);
        }
    }
}
