
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Linq;
using where_is_my_doctor.Models;

namespace where_is_my_doctor
{
    public class UserRepository
    {
        //public static bool UserAuthentication(string username, string password)
        public static bool UserAuthentication(string username, string password){
            //FormsAuthentication.HashPasswordForStoringInConfigFile has been abandoned
            var cryptoPassword = CookieAuthenticationDefaults.HashPasswordForStoringInConfigFile(password, "sha1");
            try{
                using (ApplicationDbContext dbContext = new ApplicationDbContext())
                {
                    var queryUserAuthentication = dbContext.Users
                                                    .Where(x => x.Username == username && x.Password == password)
                                                    .SingleOrDefault();
                    if (queryUserAuthentication == null){
                        return false;
                    }
                    else{
                        RegisterCookieAuthentication(queryUserAuthentication.UserID);
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void RegisterCookieAuthentication(int userId){

        }
    }
}