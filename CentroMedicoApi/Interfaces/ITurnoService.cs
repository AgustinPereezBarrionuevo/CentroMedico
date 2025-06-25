using CentroMedicoApi.Models;

namespace CentroMedicoApi.Interfaces
{
    public interface ITurnoService
    {
<<<<<<< HEAD
        Task<IEnumerable<Turno>> GetAllAsync();
        Task<Turno> GetByIdAsync(int id);
        Task<Turno> AddAsync(Turno turno);
        Task<bool> UpdateAsync(Turno turno);
        Task<bool> DeleteAsync(int id);
=======
        IEnumerable<Turno> GetAll();

        Turno Add(Turno turno);

        Turno GetById(int id);
        Turno Update(int id, Turno actualizado);
        void Delete(int id);
>>>>>>> 1180917e3681d575638bed515d97e3a9e9e74b55
    }
}
