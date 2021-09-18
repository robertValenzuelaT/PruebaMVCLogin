using Microsoft.AspNetCore.Mvc;
using PruebaMVCLogin.Models;
using PruebaMVCLogin.Data;
using System.Linq;

namespace demomvc.Controllers
{
    public class ContactController:Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            return View(_context.DataContacts.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact objContacto)
        {
            _context.Add(objContacto);
            _context.SaveChanges();
            ViewData["Message"] = "Mensaje Recibido";
            //return RedirectToAction(nameof(Index));
            return View();
        }

        
        public IActionResult Edit(int id)
        {
            Contact objContacto = _context.DataContacts.Find(id);
            if(objContacto == null){
                return NotFound();
            }
            return View(objContacto);
        }

        [HttpPost]
        public IActionResult Edit(int id,[Bind("Id,Name,Email,Comment,Phone")] Contact objContacto)
        {
             _context.Update(objContacto);
             _context.SaveChanges();
              ViewData["Message"] = "El contacto ya esta actualizado";
             return View(objContacto);
        }

        public IActionResult Delete(int id)
        {
            Contact objContacto = _context.DataContacts.Find(id);
            _context.DataContacts.Remove(objContacto);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}