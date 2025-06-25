using CentroMedicoApi.Models;

namespace CentroMedicoApi.Interfaces
{
    public interface ITurnoService
    {
        IEnumerable<Turno> GetAll();

        Turno Add(Turno turno);

        Turno GetById(int id);
        Turno Update(int id, Turno actualizado);
        void Delete(int id);
    }
}
