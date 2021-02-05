using MedialCare.Models.Catalog;
using MedialCare.Models.Data.Entities;
using MedialCare.Models.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FeedBacksController : Controller
    {

        private readonly ApplicationDbContext _context;
        public int PageSize = 5;

        public FeedBacksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Feedbacks
        public async Task<IActionResult> Index(string keySearch, int page = 1)
        {
            var query = from f in _context.Feedbacks select new { f };

            if (keySearch != null)
            {
                query = query.Where(x => x.f.FullName.Contains(keySearch));
            }
            var info = new ListViewModel
            {
                FeedBack = await query.Select(x => new FeedBack
                {
                    ID = x.f.ID,
                    FullName=x.f.FullName,
                    Email=x.f.Email,
                    Phone=x.f.Phone,
                    Content=x.f.Content,
                }).OrderBy(x => x.ID).Skip((page - 1) * PageSize).Take(PageSize).ToListAsync(),
                PagingModel = new PagingModel
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = _context.Companys.Count()
                }
            };
            return View(info);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedback = await _context.Feedbacks
                .FirstOrDefaultAsync(m => m.ID == id);
            if (feedback == null)
            {
                return NotFound();
            }
            _context.Feedbacks.Remove(feedback);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
