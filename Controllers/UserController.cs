using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;


using where_is_my_doctor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace where_is_my_doctor.Controllers
{

    public class UserController : Controller
    {

        private readonly ApplicationDbContext _myDbContext;
        private readonly ILogger<UserController> _logger;


        public UserController(ILogger<UserController> logger, ApplicationDbContext context)
        {
            _myDbContext = context;
            _logger = logger;
        }

        //Get: Users
        [HttpGet]
        public JsonResult UserAuthentication(string login, string password)
        {
            if (UserRepository.UserAuthentication(login, password))
            {
                return Json(new
                {
                    ok = true,
                    message = "User authenticated. Redirecting ..."
                });
                //depreated in Asp.net Core 1.0
                //JsonRequestBehaviour.AllowGet);
            }
            else
            {
                return Json(new
                {
                    ok = false,
                    message = "User not found. Try again"
                });
                //depreated in Asp.net Core 1.0
                //JsonRequestBehaviour.AllowGet);
            }
        }
    }
}