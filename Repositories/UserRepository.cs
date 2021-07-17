
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Linq;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

using where_is_my_doctor.Models;

namespace where_is_my_doctor
{
    public class UserRepository
    {
        public static bool UserAuthentication(string email, string password){
            //FormsAuthentication.HashPasswordForStoringInConfigFile has been abandoned
            string hashedPassword = EncryptPassword(password);
            
            try{
                using (ApplicationDbContext dbContext = new ApplicationDbContext())
                {
                    var queryUserAuthentication = dbContext.Users
                                                    .Where(x => x.Email == email && x.Password == hashedPassword)
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

        private static void RegisterCookieAuthentication(int userId){

        }

        private static string EncryptPassword(string password){
            byte[] salt = new byte[128/8];
            using(var rng = RandomNumberGenerator.Create()){
                rng.GetBytes(salt);
            }
            string encryptedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password : password,
                salt : salt,
                prf : KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8
            ));
            return encryptedPassword;
        }
    }
}