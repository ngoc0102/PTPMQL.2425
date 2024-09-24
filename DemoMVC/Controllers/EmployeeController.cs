    using DemoMVC.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
         public async Task<IActionResult> Index()
        {
            return View(await _context.Employee.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
    public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Employee = await _context.Employee.FindAsync(id);
            if (Employee == null)
            {
                return NotFound();
            }
            return View(Employee);
        }

 [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind()] Employee Employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Employee);
        }[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("")] Employee Employee)
        {
            if (id != Employee.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!personExists(Employee.ID))
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
            return View(Employee);
        }

        // GET: person/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Employee = await _context.Employee
                .FirstOrDefaultAsync(m => m.ID == id);
            if (Employee == null)
            {
                return NotFound();
            }

            return View(Employee);
        }

 [HttpPost, ActionName("Delete")]
     [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Employee = await _context.Employee.FindAsync(id);
            if (Employee != null)
            {
                _context.Employee.Remove(Employee);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool personExists(int id)
        {
            return _context.Employee.Any(e => e.ID == id);
        }
    public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Employee = await _context.Employee
                .FirstOrDefaultAsync(m => m.ID == id);
            if (Employee == null)
            {
                return NotFound();
            }

            return View(Employee);
        }

 [HttpPost, ActionName("Details")]
     [ValidateAntiForgeryToken]
        public async Task<IActionResult> DetailsConfirmed(int id)
        {
            var Employee = await _context.Employee.FindAsync(id);
            if (Employee != null)
            {
                _context.Employee.Remove(Employee);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.ID == id);
        }
    }
}
