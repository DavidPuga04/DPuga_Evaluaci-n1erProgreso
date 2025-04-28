using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DPuga_Evaluación1erProgreso.Models;

namespace DPuga_Evaluación1erProgreso.Data
{
    public class DPuga_Evaluación1erProgresoContext : DbContext
    {
        public DPuga_Evaluación1erProgresoContext (DbContextOptions<DPuga_Evaluación1erProgresoContext> options)
            : base(options)
        {
        }

        public DbSet<DPuga_Evaluación1erProgreso.Models.DPugaClientes> DPugaClientes { get; set; } = default!;
    }
}
