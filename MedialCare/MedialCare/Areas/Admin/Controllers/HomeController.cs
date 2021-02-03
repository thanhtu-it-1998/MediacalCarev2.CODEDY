using MedialCare.Areas.Account.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
