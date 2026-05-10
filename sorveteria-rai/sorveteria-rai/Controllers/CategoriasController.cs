using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sorveteria_rai.Data;
using sorveteria_rai.Models;
using sorveteria_rai.Services;

namespace sorveteria_rai.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly SorveteriaContext _context;
        private readonly CategoriaService _categoriaService;

        public CategoriasController(SorveteriaContext context, CategoriaService categoriaService)
        {
            _context = context;
            this._categoriaService = categoriaService; 
        }

        public async Task<IActionResult> Index()
        {
            var categoria = await _categoriaService.ObterCategoriaAsync();

            return View(categoria);
        }

        public async Task<IActionResult> CadastroCategoriaAsync()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SalvarCategoria(Categoria categoria)
        {
            if (!ModelState.IsValid)
            {
                return View(categoria);
            }

            await _categoriaService.SalvarCategoriaAsync(categoria);

            return RedirectToAction(nameof(Index));
        }

    }
}
