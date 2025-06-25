using CentroMedicoApi.Models;

namespace CentroMedicoApi.Interfaces
{
    public interface ITurnoService
    {
        Task<IEnumerable<Turno>> GetAllAsync();
        Task<Turno> GetByIdAsync(int id);
        Task<Turno> AddAsync(Turno turno);
        Task<bool> UpdateAsync(Turno turno);
        Task<bool> DeleteAsync(int id);
    }
}
