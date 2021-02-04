using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MedialCare.Models.EF;
using MedialCare.Models.Entities;
using MedialCare.Models.Catalog;
using MedialCare.Areas.Account.Controllers;

namespace MedialCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PoliciesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public int PageSize = 5;

        public PoliciesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Policies
        public async Task<IActionResult> Index(string keySearch, int page = 1)
        {
            var query = from p in _context.Policys select new { p };

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

        // GET: Admin/Policies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var policy = await _context.Policys
                .Include(p => p.Company)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (policy == null)
            {
                return NotFound();
            }

            return View(policy);
        }

        // GET: Admin/Policies/Create
        public IActionResult Create()
        {
            ViewData["CompanyId"] = new SelectList(_context.Companys, "ID", "Name");
            return View();
        }

        // POST: Admin/Policies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CompanyId,Name,Description,Amount,Emi")] Policy policy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(policy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompanyId"] = new SelectList(_context.Companys, "ID", "Name", policy.CompanyId);
            return View(policy);
        }

        // GET: Admin/Policies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var policy = await _context.Policys.FindAsync(id);
            if (policy == null)
            {
                return NotFound();
            }
            ViewData["CompanyId"] = new SelectList(_context.Companys, "ID", "Name", policy.CompanyId);
            return View(policy);
        }

        // POST: Admin/Policies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CompanyId,Name,Description,Amount,Emi")] Policy policy)
        {
            if (id != policy.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(policy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PolicyExists(policy.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompanyId"] = new SelectList(_context.Companys, "ID", "Name", policy.CompanyId);
            return View(policy);
        }

        // GET: Admin/Policies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var policy = await _context.Policys
                .Include(p => p.Company)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (policy == null)
            {
                return NotFound();
            }

            return View(policy);
        }

        // POST: Admin/Policies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var policy = await _context.Policys.FindAsync(id);
            _context.Policys.Remove(policy);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PolicyExists(int id)
        {
            return _context.Policys.Any(e => e.ID == id);
        }
    }
}
