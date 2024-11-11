using PracticaExamenWeb2.Data;

namespace PracticaExamenWeb2.Services
{
    public interface IVisitService
    {
        Task<List<Visita>> GetAllVisitsAsync();
        Task<Visita> GetVisitByIdAsync(int id);
        Task AddVisitAsync(Visita visit);
        Task UpdateVisitAsync(Visita visit);
        Task DeleteVisitAsync(int id);
    }
}
