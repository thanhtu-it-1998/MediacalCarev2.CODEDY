using MedialCare.Models.Catalog;
using MedialCare.Models.EF;
using MedialCare.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Controllers
{
    public class IPPController : Controller
    {
        private readonly ApplicationDbContext _context;
        public int PageSize = 5;

        public IPPController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Policies
        public async Task<IActionResult> Index(string keySearch, int page = 1)
        {
            var query =from p in _context.Policys where p.ID < 3 select new { p };

            if (keySearch != null)
            {
                query = query.Where(x => x.p.Name.Contains(keySearch)).Include(x => x.p.Company);
            }
            var info = new ListViewModel
            {
                Policy = await query.Select(x => new Policy
                {
                    ID = x.p.ID,
                    Name = x.p.Name,
                    Description = x.p.Description,
                    Amount = x.p.Amount,
                    Emi = x.p.Emi,
                    Company = x.p.Company,
                }).OrderBy(x => x.ID)
                .Skip((page - 1) * PageSize).Take(PageSize).ToListAsync(),
                PagingModel = new PagingModel
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = _context.Policys.Count()
                }
            };
            return View(info);
        }
    }
}
