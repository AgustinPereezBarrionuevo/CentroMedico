using CentroMedicoApi.Interfaces;
using CentroMedicoApi.Models;
using CentroMedicoApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CentroMedicoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfesionalController : ControllerBase
    {
        private readonly IProfesionalService _service;

        public ProfesionalController(IProfesionalService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Profesional>> Get() => await _service.GetAllAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Profesional>> GetById(int id)
        {
            var profesional = await _service.GetByIdAsync(id);
            if (profesional == null) return NotFound();
            return profesional;
        }

        [HttpPost]
        public async Task<ActionResult<Profesional>> Post(Profesional profesional)
        {
            var created = await _service.AddAsync(profesional);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Profesional profesional)
        {
            if (id != profesional.Id) return BadRequest();

            var updated = await _service.UpdateAsync(profesional);
            if (!updated) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _service.DeleteAsync(id);
            if (!deleted) return NotFound();

            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult<Profesional> Update(int id, [FromBody] Profesional profesionalActualizado)
        {
            var paciente = _profesionalService.GetById(id);
            if (paciente == null)
                return NotFound();

            paciente.Nombre = profesionalActualizado.Nombre;
            paciente.Especialidad = profesionalActualizado.Especialidad;
            paciente.Matricula = profesionalActualizado.Matricula;

            return Ok(paciente);
        }


        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var profesional = _profesionalService.GetById(id);
            if (profesional == null)
                return NotFound();

            _profesionalService.Delete(id);
            return NoContent();
        }

    }
}
