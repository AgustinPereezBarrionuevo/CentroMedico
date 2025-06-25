using CentroMedicoApi.Interfaces;
using CentroMedicoApi.Models;


namespace CentroMedicoApi.Services
{
    public class CentroMedicoService : ICentroMedicoService
    {

        private static readonly List<CentroMedico> _centros = new List<CentroMedico>();
        private static int _nextId = 1;

        public IEnumerable<CentroMedico> GetAll()
          {
                return _centros;
          }

          public CentroMedico Add(CentroMedico centro)
          {

            if (centro.Id == 0)
            {
                centro.Id = _nextId++; 
            }
            _centros.Add(centro);
                return centro;
          }

        public CentroMedico GetById(int id)
        {
            return _centros.FirstOrDefault(c => c.Id == id);
        }

        public CentroMedico Update(int id, CentroMedico actualizado)
        {
            var existente = GetById(id);
            if (existente == null)
                return null;

            existente.Nombre = actualizado.Nombre;
            existente.Direccion = actualizado.Direccion;
            existente.Telefono = actualizado.Telefono;

            return existente;
        }

        public void Delete(int id)
        {
            var centro = GetById(id);
            if (centro != null)
            {
                _centros.Remove(centro);
            }
        }

    }
}
