using CentroMedicoApi.Models;

namespace CentroMedicoApi.Interfaces
{
    public interface IProfesionalService
    {
        IEnumerable<Profesional> GetAll();

        Profesional Add (Profesional profesional);
    }
}
