using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticaExamenWeb2.Data;

namespace PracticaExamenWeb2.Services
{
    public class VisitService : IVisitService
    {
        private readonly VisitasContext _context;

        public VisitService(VisitasContext context)
        {
            _context = context;
        }

        // Obtener todas las visitas
        public async Task<List<Visita>> GetAllVisitsAsync()
        {
            return await _context.Visitas.ToListAsync();
        }

        // Obtener una visita por ID
        public async Task<Visita> GetVisitByIdAsync(int id)
        {
            return await _context.Visitas.FindAsync(id);
        }

        // Agregar una nueva visita
        public async Task AddVisitAsync(Visita visit)
        {
            _context.Visitas.Add(visit);
            await _context.SaveChangesAsync();
        }

        // Actualizar una visita existente
        public async Task UpdateVisitAsync(Visita visit)
        {
            _context.Entry(visit).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        // Eliminar una visita por ID
        public async Task DeleteVisitAsync(int id)
        {
            var visit = await _context.Visitas.FindAsync(id);
            if (visit != null)
            {
                _context.Visitas.Remove(visit);
                await _context.SaveChangesAsync();
            }
        }
    }
}
