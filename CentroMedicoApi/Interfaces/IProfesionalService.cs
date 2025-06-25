using CentroMedicoApi.Models;

namespace CentroMedicoApi.Interfaces
{
    public interface IProfesionalService
    {
<<<<<<< HEAD
        Task<IEnumerable<Profesional>> GetAllAsync();
        Task<Profesional> GetByIdAsync(int id);
        Task<Profesional> AddAsync(Profesional profesional);
        Task<bool> UpdateAsync(Profesional profesional);
        Task<bool> DeleteAsync(int id);
=======
        IEnumerable<Profesional> GetAll();

        Profesional Add (Profesional profesional);

        Profesional GetById(int id);
        Profesional Update(int id, Profesional actualizado);
        void Delete(int id);
>>>>>>> 1180917e3681d575638bed515d97e3a9e9e74b55
    }
}
