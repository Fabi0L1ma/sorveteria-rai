using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sorveteria_rai.Data;
using sorveteria_rai.Models;

namespace sorveteria_rai.Repository
{
    public class CategoriaRepository 
    {
        private readonly SorveteriaContext _context;

        public CategoriaRepository(SorveteriaContext context)
        {
            _context = context;
        }
        public async Task SalvarCategoriaAsync(Categoria categoria)
        {
            _context.Categoria.Add(categoria);

            await _context.SaveChangesAsync();
        }

        public async Task<List<Categoria>> ObterCategoriaAsync()
        {
            return await _context.Categoria.ToListAsync();
        }
    }
}
