using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pc3simulacro.Models;
using Microsoft.EntityFrameworkCore;


using pc3simulacro.Data;

namespace pc3simulacro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger , ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
          var solicitudes = _context.solicitud
                                        .Include(s => s.Usuario)
                                        .ToList();

            return View(solicitudes);
        }
        public IActionResult Registro (){
            return View();
        }
        [HttpPost]
        public IActionResult Registro(Solicitud so){
            
            var usuario = _context.Usuarios.First(u => u.Id == 1);
                so.Usuario = usuario;
                _context.Add(so);
                _context.SaveChanges();
                return RedirectToAction("Index");
            
           
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
