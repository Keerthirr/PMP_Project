using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PensionManagementPortal.Models;

namespace PensionManagementPortal.Controllers
{
    public class PensionController : Controller
    {
        private readonly PMPContext _context;

        public PensionController(PMPContext context)
        {
            _context = context;
        }

        // GET: Pension
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pensioners.ToListAsync());
        }

        // GET: Pension/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pensioner = await _context.Pensioners
                .FirstOrDefaultAsync(m => m.PensionerId == id);
            if (pensioner == null)
            {
                return NotFound();
            }

            return View(pensioner);
        }

        // GET: Pension/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pension/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PensionerId,AadharId,Name,Age,Gender,Address,MobileNo,BankName,AccountNumber,PensionAmount,Reason")] Pensioner pensioner)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pensioner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pensioner);
        }

        // GET: Pension/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pensioner = await _context.Pensioners.FindAsync(id);
            if (pensioner == null)
            {
                return NotFound();
            }
            return View(pensioner);
        }

        // POST: Pension/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PensionerId,AadharId,Name,Age,Gender,Address,MobileNo,BankName,AccountNumber,PensionAmount,Reason")] Pensioner pensioner)
        {
            if (id != pensioner.PensionerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pensioner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PensionerExists(pensioner.PensionerId))
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
            return View(pensioner);
        }

        // GET: Pension/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pensioner = await _context.Pensioners
                .FirstOrDefaultAsync(m => m.PensionerId == id);
            if (pensioner == null)
            {
                return NotFound();
            }

            return View(pensioner);
        }

        // POST: Pension/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pensioner = await _context.Pensioners.FindAsync(id);
            _context.Pensioners.Remove(pensioner);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PensionerExists(int id)
        {
            return _context.Pensioners.Any(e => e.PensionerId == id);
        }




        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(Login cred)
        {
            string userName = cred.Username;
            var user = await _context.Logins.FindAsync(cred.Username);
            if (user == null)
            {
                ViewBag.errors = "Username is Invalid";
                return View();
            }
            if (user.Password == cred.Password)
            {
                return View("PensionerData");
            }
            ViewBag.errors = "Password is Invalid";
            return View();
        }

        public async Task<IActionResult> PensionerData()
        {
            return View(await _context.Pensioners.ToListAsync());
        }
        
        public ActionResult DeletebyAadhar()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletebyAadhar( int aadhar)
        {
            var check = await _context.Pensioners.FindAsync(aadhar);

            if (check == null)
            {
                ViewBag.errors = "Pensioner adhaar number are Invalid" + aadhar.ToString();
                return View();
            }
            ViewBag.msg2 = "Deleted successfully";
            _context.Pensioners.Remove(check);
           await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
