using CentroMedicoApi.Models;

namespace CentroMedicoApi.Interfaces
{
    public interface ICentroMedicoService
    {
<<<<<<< HEAD
        Task<IEnumerable<CentroMedico>> GetAllAsync();
        Task<CentroMedico> GetByIdAsync(int id);
        Task<CentroMedico> AddAsync(CentroMedico centroMedico);
        Task<bool> UpdateAsync(CentroMedico centroMedico);
        Task<bool> DeleteAsync(int id);
=======
        IEnumerable<CentroMedico> GetAll();
        CentroMedico Add(CentroMedico centro);

        CentroMedico GetById(int id);
        CentroMedico Update(int id, CentroMedico actualizado);
        void Delete(int id);
>>>>>>> 1180917e3681d575638bed515d97e3a9e9e74b55
    }
}
