using Microsoft.EntityFrameworkCore.Metadata.Internal;
using sorveteria_rai.Data;
using sorveteria_rai.Models;
using sorveteria_rai.Repository;

namespace sorveteria_rai.Services
{
    public class CategoriaService
    {
        private readonly SorveteriaContext _context;
        private readonly CategoriaRepository _categoriaRepository;

        public CategoriaService(SorveteriaContext context)
        {
            this._context = context;
        }

        public async Task SalvarCategoriaAsync(Categoria categoria)
        {
            if(categoria == null)
            {
                throw new Exception("Categoria está vazia.");
            }

            await _categoriaRepository.SalvarCategoriaAsync(categoria);
        }

        public async Task<List<Categoria>> ObterCategoriaAsync()
        {
            return await _categoriaRepository.ObterCategoriaAsync();
        }

    }
}
