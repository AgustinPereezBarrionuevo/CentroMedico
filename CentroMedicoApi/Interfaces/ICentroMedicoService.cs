using CentroMedicoApi.Models;

namespace CentroMedicoApi.Interfaces
{
    public interface ICentroMedicoService
    {
        Task<IEnumerable<CentroMedico>> GetAllAsync();
        Task<CentroMedico> GetByIdAsync(int id);
        Task<CentroMedico> AddAsync(CentroMedico centroMedico);
        Task<bool> UpdateAsync(CentroMedico centroMedico);
        Task<bool> DeleteAsync(int id);
    }
}
