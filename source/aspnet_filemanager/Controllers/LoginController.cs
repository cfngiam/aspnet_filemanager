using aspnet_filemanager.Business;
using aspnet_filemanager.Models;
using System;
using System.Web.Mvc;


namespace aspnet_filemanager.Controllers
{
    public class LoginController : Controller
    {
        private UserBusiness userBusiness = new UserBusiness();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(User user)
        {
            try
            {
                userBusiness.LogInUser(user.Email, user.Password);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception error)
            {
                TempData["Error"] = error.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult ForgotPassword(User user)
        {
            try
            {
                userBusiness.ResetPassword(user.Email);
                TempData["Success"] = "Email reseted successfully.";
                return RedirectToAction("Index");
            }
            catch (Exception error)
            {
                TempData["Error"] = error.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult LogOff()
        {
            userBusiness.LogOffUser();
            return RedirectToAction("Login", "Login");
        }
    }
}