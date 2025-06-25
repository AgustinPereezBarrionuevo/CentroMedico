using CentroMedicoApi.Interfaces;
using CentroMedicoApi.Models;
using CentroMedicoApi.Services;
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

        [HttpPut("{id}")]
        public ActionResult<Paciente> Update(int id, [FromBody] Paciente pacienteActualizado)
        {
            var paciente = _pacienteService.GetById(id);
            if (paciente == null)
                return NotFound();

            paciente.Nombre = pacienteActualizado.Nombre;
            paciente.Dni = pacienteActualizado.Dni;
            paciente.Email = pacienteActualizado.Email;

            return Ok(paciente);
        }


        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var paciente = _pacienteService.GetById(id);
            if (paciente == null)
                return NotFound();

            _pacienteService.Delete(id);
            return NoContent();
        }
    }
}
