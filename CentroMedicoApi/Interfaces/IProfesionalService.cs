using CentroMedicoApi.Models;

namespace CentroMedicoApi.Interfaces
{
    public interface IProfesionalService
    {
        Task<IEnumerable<Profesional>> GetAllAsync();
        Task<Profesional> GetByIdAsync(int id);
        Task<Profesional> AddAsync(Profesional profesional);
        Task<bool> UpdateAsync(Profesional profesional);
        Task<bool> DeleteAsync(int id);
    }
}
