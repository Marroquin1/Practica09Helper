using Microsoft.AspNetCore.Mvc;

namespace Practica09Helper.Controllers
{
    public class EquiposController : Controller
    {
        private readonly equiposDbContext _equiposDbContext;
        public IActionResult Index()
        {
            return View();
        }
    }
}
