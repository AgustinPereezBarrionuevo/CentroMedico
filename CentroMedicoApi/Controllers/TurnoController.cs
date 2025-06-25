using CentroMedicoApi.Interfaces;
using CentroMedicoApi.Models;
using CentroMedicoApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CentroMedicoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TurnoController : ControllerBase
    {
        private readonly ITurnoService _service;

        public TurnoController(ITurnoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Turno>> Get() => await _service.GetAllAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Turno>> GetById(int id)
        {
            var turno = await _service.GetByIdAsync(id);
            if (turno == null) return NotFound();
            return turno;
        }

        [HttpPost]
        public async Task<ActionResult<Turno>> Post(Turno turno)
        {
            var created = await _service.AddAsync(turno);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Turno turno)
        {
            if (id != turno.Id) return BadRequest();

            var updated = await _service.UpdateAsync(turno);
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
    }
}
