using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaMVCLogin.Models;
using PruebaMVCLogin.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace PruebaMVCLogin.Controllers
{
    public class CatalogoController : Controller
    {

        private readonly ApplicationDbContext _context;

        public CatalogoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var productos = from o in _context.DataProducts select o;
            return View(await productos.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            Product objProduct = await _context.DataProducts.FindAsync(id);
            if(objProduct == null){
                return NotFound();
            }
            return View(objProduct);
        }
        
    }
}