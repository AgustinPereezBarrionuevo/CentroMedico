using CentroMedicoApi.Interfaces;
using CentroMedicoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CentroMedicoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CentroMedicoController : ControllerBase
    {
        private readonly ICentroMedicoService _centroService;

        public CentroMedicoController(ICentroMedicoService centroService)
        {
            _centroService = centroService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CentroMedico>> GetAll()
        {
            return Ok(_centroService.GetAll());
        }

        [HttpPost]
        public ActionResult<CentroMedico> Add(CentroMedico centro)
        {
            var nuevo = _centroService.Add(centro);
            return CreatedAtAction(nameof(GetAll), new { id = nuevo.Id }, nuevo);
        }
    }
}
