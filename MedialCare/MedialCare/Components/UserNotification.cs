using MedialCare.Areas.Admin.Models.Common;
using MedialCare.Models.EF;
using MedialCare.Models.Enum;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Components
{
    public class UserNotification:ViewComponent
    {
        public readonly ApplicationDbContext _context;
        public UserNotification(ApplicationDbContext  context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
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

          
            ViewBag.Count = res.Count();
            return View(res);
        }
        //public IViewComponentResult DeteleResquest()
        //{

        //}
    }
}
