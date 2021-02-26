using MedialCare.Areas.Account.Controllers;
using MedialCare.Areas.Admin.Models.Common;
using MedialCare.Models.EF;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RequestPoliciesController : CheckAccountController
    {
        public readonly ApplicationDbContext _context;
        public RequestPoliciesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var query = (from r in _context.RequestPolicies
                         join p in _context.Policys on r.PolicyID equals p.ID
                         join c in _context.Companys on p.CompanyId equals c.ID
                         join u in _context.Users on r.UserID equals u.ID
                         select new { c, p, r, u });

            var res = query.Select(x => new RequestPoliciesModel
            {
                ID = x.r.ID,
                Company = x.c.Name,
                Policies = x.p.Name,
                User = x.u.Username,
                Date = x.r.CreatedAt,
                Status = x.r.Status
            }).ToList();

            return View(res);
        }
        public IActionResult Delete(int ID)
        {
            if (ID == null)
            {
                return NotFound();
            }

            var feedback =  _context.RequestPolicies
                .FirstOrDefault(m => m.ID == ID);
            if (feedback == null)
            {
                return NotFound();
            }
            _context.RequestPolicies.Remove(feedback);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
