using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel;

namespace PracticaExamenWeb2.Data
{
    public class VisitasContext : DbContext
    {
        public VisitasContext(DbContextOptions<VisitasContext> options) : base(options) { }
        public DbSet<Visita> Visitas { get; set; }
    }
}
