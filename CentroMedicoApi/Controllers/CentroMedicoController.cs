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

        [HttpPut("{id}")]
        public ActionResult<CentroMedico> Update(int id, [FromBody] CentroMedico centroMedicoActualizado)
        {
            var centro = _centroService.GetById(id);
            if (centro == null)
                return NotFound();

            centro.Nombre = centroMedicoActualizado.Nombre;
            centro.Direccion = centroMedicoActualizado.Direccion;
            centro.Telefono = centroMedicoActualizado.Telefono;

            return Ok(centro);
        }


        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var centro = _centroService.GetById(id);
            if (centro == null)
                return NotFound();

            _centroService.Delete(id);
            return NoContent();
        }


    }

<<<<<<< HEAD
=======
     

    

>>>>>>> 1180917e3681d575638bed515d97e3a9e9e74b55
}
