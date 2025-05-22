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
        
    }
}
