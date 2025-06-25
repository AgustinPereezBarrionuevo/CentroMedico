using CentroMedicoApi.Models;

namespace CentroMedicoApi.Interfaces
{
    public interface IProfesionalService
    {
        IEnumerable<Profesional> GetAll();

        Profesional Add (Profesional profesional);

        Profesional GetById(int id);
        Profesional Update(int id, Profesional actualizado);
        void Delete(int id);
    }
}
