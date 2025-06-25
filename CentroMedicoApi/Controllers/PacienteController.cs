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
        public async Task<ActionResult<IEnumerable<Paciente>>> Get()
        {
            var pacientes = await _pacienteService.GetAllAsync();
            return Ok(pacientes);
        }

        [HttpPost]
        public async Task<ActionResult<Paciente>> Post(Paciente paciente)
        {
            var nuevo = await _pacienteService.AddAsync(paciente);
            return CreatedAtAction(nameof(Get), new { id = nuevo.Id }, nuevo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Paciente paciente)
        {
            if (id != paciente.Id)
                return BadRequest();

            await _pacienteService.UpdateAsync(paciente);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _pacienteService.DeleteAsync(id);
            return NoContent();
        }
    }
}
