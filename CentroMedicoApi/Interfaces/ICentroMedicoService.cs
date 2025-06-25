using CentroMedicoApi.Models;

namespace CentroMedicoApi.Interfaces
{
    public interface ICentroMedicoService
    {
        IEnumerable<CentroMedico> GetAll();
        CentroMedico Add(CentroMedico centro);

        CentroMedico GetById(int id);
        CentroMedico Update(int id, CentroMedico actualizado);
        void Delete(int id);
    }
}
