using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sorveteria_rai.Data;
using sorveteria_rai.Models;

namespace sorveteria_rai.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly sorveteriaContext _context;

        public CategoriasController(sorveteriaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

    }
}
