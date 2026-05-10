using Microsoft.AspNetCore.Mvc;

namespace sorveteria_rai.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastroCategoria()
        {
            return View();
        }
    }
}
