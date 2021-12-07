using Florella_project.Data;
using Florella_project.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Florella_project.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(new HomeViewModel { 
                Experts = _context.Experts.ToList(),
                ExpSectionHeader = _context.ExpSectionHeader.FirstOrDefault()
            });
        }
    }
}
