using MedialCare.Models.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MedialCare.Models.Catalog.RequestPoliciesModel;

//Insurance waiting for approval

namespace MedialCare.Controllers
{
    public class IWFAController : Controller
    {
        public readonly ApplicationDbContext _context;
        public IWFAController(ApplicationDbContext context)
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

            var res = query.Select(x => new RequestPoliciesModels
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

        public IActionResult ChangeStatus(int ID)
        {
            var res = _context.RequestPolicies.Where(x => x.ID == ID).FirstOrDefault();
            res.Status = MedialCare.Models.Enum.Status.Approval;
            _context.Entry(res).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
