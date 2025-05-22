using CentroMedicoApi.Interfaces;
using CentroMedicoApi.Models;

namespace CentroMedicoApi.Services
{
    public class TurnoService : ITurnoService
    {
        private static readonly List<Turno> _turnos = new List<Turno>();
        private static int _nextId = 1;

        public IEnumerable<Turno> GetAll()
        {
            return _turnos;
        }

        public Turno Add(Turno turno)
        {
            turno.Id = _nextId++;
            turno.Estado = "Pendiente"; // Estado inicial
            _turnos.Add(turno);
            return turno;
        }
    }
}
