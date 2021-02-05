using MedialCare.Areas.Account.Controllers;
using MedialCare.Models;
using MedialCare.Models.Catalog;
using MedialCare.Models.Data.Entities;
using MedialCare.Models.EF;
using MedialCare.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Controllers
{
    public class HomeController : BaseController
    {

        public readonly ApplicationDbContext context;
        public int PageSize = 5;
        public HomeController(ApplicationDbContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            var companys = context.Companys.ToList();
            return View(companys);
        }
        [HttpGet]
        public IActionResult PolicyOfCompany(int ID, string keySearch, int page = 1)
        {
            var query = from p in context.Policys select new { p };

            if (keySearch != null)
            {
                query = query.Where(x => x.p.Name.Contains(keySearch));
            }
            var info = new RequetModel
            {
                Policies = query.Select(x => new Policy
                {
                    ID = x.p.ID,
                    Name = x.p.Name,
                    Description = x.p.Description,
                    Amount = x.p.Amount,
                    Emi = x.p.Emi,
                }).Where(x => x.ID == ID)
                .OrderBy(x => x.ID)
                .Skip((page - 1) * PageSize)
                .Take(PageSize).ToList(),
                PagingModel = new PagingModel
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = context.Policys.Count()
                },
                Company = context.Companys.Find(ID),
                Key = (keySearch != null) ? keySearch : null

            };
            return View(info);
        }

        public IActionResult PolicyHandl(int ID)
        {
            RequestPolicy request = new RequestPolicy()
            {
                PolicyID = ID,
                UserID= (int)HttpContext.Session.GetInt32("IDSession"),
            };
            context.RequestPolicies.Add(request);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
