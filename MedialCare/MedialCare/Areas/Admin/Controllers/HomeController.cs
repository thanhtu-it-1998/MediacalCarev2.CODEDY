using MedialCare.Areas.Account.Controllers;
using MedialCare.Areas.Admin.Models.Common;
using MedialCare.Models.EF;
using MedialCare.Models.Enum;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Area("Admin")]
        public IActionResult Index()
        {
            var overview = new OverviewModel()
            {
                Appointment = _context.PolicyOnEmployees
                              .Where(x => x.Status == Status.Request)
                              .Count(),
                TotalPartient = _context.Users
                                .Where(x => x.Level == Level.Employee)
                                .Count(),
                TotalCompany = _context.Companys.Count(),
                Earning = _context.PolicyOnEmployees
                            .Where(x => x.Status == Status.Approval)
                              .Count(),
                User = _context.Users.Where( x=>x.Level == Level.Admin).ToList(),

            };
            return View(overview);

        }
    }
}
