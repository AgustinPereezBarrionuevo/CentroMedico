using CentroMedicoApi.Interfaces;
using CentroMedicoApi.Models;

namespace CentroMedicoApi.Services
{
    public class PacienteService : IPacienteService
    {
        private static readonly List<Paciente> _pacientes = new List<Paciente>();
        private static int _nextId = 1;

        public IEnumerable<Paciente> GetAll()
        {
            return _pacientes;
        }

        public Paciente Add(Paciente paciente)
        {
            paciente.Id = _nextId++;
            _pacientes.Add(paciente);
            return paciente;
        }
    }
}
