using CentroMedicoApi.Interfaces;
using CentroMedicoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CentroMedicoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfesionalController : ControllerBase
    {
        private readonly IProfesionalService _profesionalService;

        public ProfesionalController(IProfesionalService profesionalService)
        {
            _profesionalService = profesionalService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Profesional>> GetAll()
        {
            return Ok(_profesionalService.GetAll());
        }

        [HttpPost]
        public ActionResult<Profesional> Add(Profesional profesional)
        {
            var nuevo = _profesionalService.Add(profesional);
            return CreatedAtAction(nameof(GetAll), new { id = nuevo.Id }, nuevo);
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
