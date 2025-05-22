using CentroMedicoApi.Models;

namespace CentroMedicoApi.Interfaces
{
    public interface IPacienteService
    {
        IEnumerable<Paciente> GetAll();

        Paciente Add(Paciente paciente);
    }
}
