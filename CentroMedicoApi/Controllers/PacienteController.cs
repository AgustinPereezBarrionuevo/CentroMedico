using CentroMedicoApi.Interfaces;
using CentroMedicoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CentroMedicoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteService _pacienteService;

        public PacienteController(IPacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Paciente>> GetAll()
        {
            return Ok(_pacienteService.GetAll());
        }

        [HttpPost]
        public ActionResult<Paciente> Add(Paciente paciente)
        {
            var nuevo = _pacienteService.Add(paciente);
            return CreatedAtAction(nameof(GetAll), new { id = nuevo.Id }, nuevo);
        }
    }
}
