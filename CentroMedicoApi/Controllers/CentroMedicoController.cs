using CentroMedicoApi.Interfaces;
using CentroMedicoApi.Models;
using CentroMedicoApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CentroMedicoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CentroMedicoController : ControllerBase
    {
        private readonly ICentroMedicoService _service;

        public CentroMedicoController(ICentroMedicoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<CentroMedico>> Get() => await _service.GetAllAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<CentroMedico>> GetById(int id)
        {
            var centro = await _service.GetByIdAsync(id);
            if (centro == null) return NotFound();
            return centro;
        }

        [HttpPost]
        public async Task<ActionResult<CentroMedico>> Post(CentroMedico centroMedico)
        {
            var created = await _service.AddAsync(centroMedico);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CentroMedico centroMedico)
        {
            if (id != centroMedico.Id) return BadRequest();

            var updated = await _service.UpdateAsync(centroMedico);
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
