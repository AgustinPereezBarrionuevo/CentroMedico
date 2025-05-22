using CentroMedicoApi.Models;

namespace CentroMedicoApi.Interfaces
{
    public interface ITurnoService
    {
        IEnumerable<Turno> GetAll();

        Turno Add(Turno turno);
        
    }
}
