using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Practica09Helper.Models;


namespace Practica09Helper.Controllers
{
    public class Equipos2Controller : Controller
    {
        private readonly equiposDbContext _equiposDbContext;
        public Equipos2Controller(equiposDbContext equiposDbContext)
        {
            _equiposDbContext = equiposDbContext;
        }
        public IActionResult Index()
        {
            var listaDeMarcas = (from m in _equiposDbContext.marcas
                                 select m).ToList();
            ViewData["listadoDeMarcas"] = new SelectList(listaDeMarcas, "id_marcas", "nombre_marca");

            var listaDeEquipos = (from e in _equiposDbContext.equipos
                                  join m in _equiposDbContext.marcas on e.marca_id equals m.id_marcas
                                  select new
                                  {
                                      nombre = e.nombre,
                                      descripcion = e.descripcion,
                                      marca_id = e.marca_id,
                                      marca_nombre = m.nombre_marcas
                                  }).ToList();
            ViewData["listadoDeEquipos"] = listaDeEquipos;

            return View();
        }
        public IActionResult CrearEquipos(equipos nuevoEquipo)
        {
            _equiposDbContext.Add(nuevoEquipo);
            _equiposDbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
