using MedialCare.Areas.Account.Data;
using MedialCare.Areas.Account.Models;
using MedialCare.Models.EF;
using MedialCare.Models.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Areas.Account.Controllers
{
    [Area("Account")]
    public class LoginController : Controller
    {
        const string UserSession = "UserSession";

        const string IDSession = "IDSession";

        public ApplicationDbContext context;

        public LoginController(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao(context);
                var result = dao.Login(model.UserName, model.Password,model.Level);
                if (result)
                {
                    var user = dao.GetByID(model.UserName);
                    HttpContext.Session.SetString(UserSession, user.Username);
                    HttpContext.Session.SetInt32(IDSession, user.ID);
                    if (user.Level == Level.Admin)
                    {
                        return RedirectToAction("Index", "Home", new { area = "Admin" });
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home", new { area = "" });

                    }
                }
                else
                    ModelState.AddModelError("", "Login feild. Please enter user and password");
            }
            return View("Index");
        }
    }
}
