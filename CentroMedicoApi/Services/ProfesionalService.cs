using CentroMedicoApi.Interfaces;
using CentroMedicoApi.Models;

namespace CentroMedicoApi.Services
{
    public class ProfesionalService : IProfesionalService
    {
        private static readonly List<Profesional> _profesionales = new List<Profesional>();
        private static int _nextId = 1;

        public IEnumerable<Profesional> GetAll()
        {
            return _profesionales;
        }

        public Profesional Add(Profesional profesional)
        {
            profesional.Id = _nextId++;
            _profesionales.Add(profesional);
            return profesional;
        }

        public Profesional GetById(int id)
        {
            return _profesionales.FirstOrDefault(c => c.Id == id);
        }

        public Profesional Update(int id, Profesional actualizado)
        {
            var existente = GetById(id);
            if (existente == null)
                return null;

            existente.Nombre = actualizado.Nombre;
            existente.Especialidad = actualizado.Especialidad;
            existente.Matricula = actualizado.Matricula;

            return existente;
        }

        public void Delete(int id)
        {
            var profesional = GetById(id);
            if (profesional != null)
            {
                _profesionales.Remove(profesional);
            }
        }
    }
}
