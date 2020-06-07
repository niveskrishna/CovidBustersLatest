using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hackathon.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hackathon.Controllers
{
    public class UserController : Controller
    {
        private ILoginHelper _iloginHelper;
        public UserController()
        {
            _iloginHelper = new LoginHelper();
        }
        public String Register(string userName, string password)
        {
         //int registrationResult=   _iloginHelper.RegisterUser(userName, password);  
         //   if(registrationResult>0)
         //   {
                return "Congratulations!!!Registration successful...Click on exsisting user to get started!";
            //}
            //return "Server Down..Please try Again Later!";      
        
        }
        public Boolean Login(string userName,string password)
        //public IActionResult Login()
        {
            //Boolean loginResult = _iloginHelper.AuthenticateUser(userName, password);
            //if (loginResult)
            //{

            //} 
             HttpContext.Session.SetString("UserName", userName);
            return false;
        }
        public IActionResult LogOut()
        {           
            HttpContext.Session.SetString("UserName", string.Empty);
            return RedirectToAction("Index", "Home");
        }
    }
}