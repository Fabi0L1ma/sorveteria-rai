using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sorveteria_rai.Models;

namespace sorveteria_rai.Data
{
    public class SorveteriaContext : DbContext
    {
        public SorveteriaContext(DbContextOptions<SorveteriaContext> options)
            : base(options)
        {
        }

        public DbSet<sorveteria_rai.Models.Categoria> Categoria { get; set; } = default!;
    }
}
