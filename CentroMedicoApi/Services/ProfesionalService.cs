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
    }
}
