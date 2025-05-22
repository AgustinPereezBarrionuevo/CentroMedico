using CentroMedicoApi.Models;

namespace CentroMedicoApi.Interfaces
{
    public interface ICentroMedicoService
    {
        IEnumerable<CentroMedico> GetAll();
        CentroMedico Add(CentroMedico centro);
    }
}
