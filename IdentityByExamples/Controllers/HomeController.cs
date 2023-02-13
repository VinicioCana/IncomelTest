using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Test.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationContext _context;

        public HomeController(ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListEmployees()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Employees()
        {
            var employees = await _context.Employees.ToListAsync();
            return View(employees);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult addEmployee()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> addEmployee(Employee employees)
        {
            if (ModelState.IsValid)
            {
                employees.User = User.Identity.Name;
                employees.Created = DateTime.Now;
                _context.Add(employees);
                await _context.SaveChangesAsync();
            
            }
            return RedirectToAction(nameof(employees));
           
        }
    }
}
