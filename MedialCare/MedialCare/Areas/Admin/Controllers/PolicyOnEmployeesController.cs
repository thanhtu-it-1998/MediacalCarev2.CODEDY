using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MedialCare.Models.EF;
using MedialCare.Models.Entities;

namespace MedialCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PolicyOnEmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PolicyOnEmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/PolicyOnEmployees
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PolicyOnEmployees.Include(p => p.Policy).Include(p => p.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/PolicyOnEmployees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var policyOnEmployee = await _context.PolicyOnEmployees
                .Include(p => p.Policy)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (policyOnEmployee == null)
            {
                return NotFound();
            }

            return View(policyOnEmployee);
        }

        // GET: Admin/PolicyOnEmployees/Create
        public IActionResult Create()
        {
            ViewData["PolicyId"] = new SelectList(_context.Policys, "ID", "Description");
            ViewData["UserId"] = new SelectList(_context.Users, "ID", "Address");
            return View();
        }

        // POST: Admin/PolicyOnEmployees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,UserId,PolicyId,StartDate,EndDate,Status,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy,Version,Deleted")] PolicyOnEmployee policyOnEmployee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(policyOnEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PolicyId"] = new SelectList(_context.Policys, "ID", "Description", policyOnEmployee.PolicyId);
            ViewData["UserId"] = new SelectList(_context.Users, "ID", "Address", policyOnEmployee.UserId);
            return View(policyOnEmployee);
        }

        // GET: Admin/PolicyOnEmployees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var policyOnEmployee = await _context.PolicyOnEmployees.FindAsync(id);
            if (policyOnEmployee == null)
            {
                return NotFound();
            }
            ViewData["PolicyId"] = new SelectList(_context.Policys, "ID", "Description", policyOnEmployee.PolicyId);
            ViewData["UserId"] = new SelectList(_context.Users, "ID", "Address", policyOnEmployee.UserId);
            return View(policyOnEmployee);
        }

        // POST: Admin/PolicyOnEmployees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,UserId,PolicyId,StartDate,EndDate,Status,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy,Version,Deleted")] PolicyOnEmployee policyOnEmployee)
        {
            if (id != policyOnEmployee.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(policyOnEmployee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PolicyOnEmployeeExists(policyOnEmployee.ID))
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
            ViewData["PolicyId"] = new SelectList(_context.Policys, "ID", "Description", policyOnEmployee.PolicyId);
            ViewData["UserId"] = new SelectList(_context.Users, "ID", "Address", policyOnEmployee.UserId);
            return View(policyOnEmployee);
        }

        // GET: Admin/PolicyOnEmployees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var policyOnEmployee = await _context.PolicyOnEmployees
                .Include(p => p.Policy)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (policyOnEmployee == null)
            {
                return NotFound();
            }

            return View(policyOnEmployee);
        }

        // POST: Admin/PolicyOnEmployees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var policyOnEmployee = await _context.PolicyOnEmployees.FindAsync(id);
            _context.PolicyOnEmployees.Remove(policyOnEmployee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PolicyOnEmployeeExists(int id)
        {
            return _context.PolicyOnEmployees.Any(e => e.ID == id);
        }
    }
}
