using CentroMedicoApi.Models;

namespace CentroMedicoApi.Interfaces
{
    public interface IPacienteService
    {
        IEnumerable<Paciente> GetAll();
        Paciente GetById(int id);      
        void Delete(int id);

        Paciente Add(Paciente paciente);
    }
}
