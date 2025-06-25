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

        public Turno GetById(int id)
        {
            return _turnos.FirstOrDefault(t => t.Id == id);
        }

        public Turno Update(int id, Turno actualizado)
        {
            var existente = GetById(id);
            if (existente == null)
                return null;

            existente.PacienteId = actualizado.PacienteId;
            existente.ProfesionalId = actualizado.ProfesionalId;
            existente.FechaHora = actualizado.FechaHora;
            existente.Estado = actualizado.Estado;

            return existente;
        }

        public void Delete(int id)
        {
            var turno = GetById(id);
            if (turno != null)
                _turnos.Remove(turno);
        }
    }
}
