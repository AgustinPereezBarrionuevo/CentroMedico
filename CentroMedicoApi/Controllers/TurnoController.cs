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
        private readonly ITurnoService _turnoService;

        public TurnoController(ITurnoService turnoService)
        {
            _turnoService = turnoService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Turno>> GetAll()
        {
            return Ok(_turnoService.GetAll());
        }

        [HttpPost]
        public ActionResult<Turno> Add(Turno turno)
        {
            var nuevo = _turnoService.Add(turno);
            return CreatedAtAction(nameof(GetAll), new { id = nuevo.Id }, nuevo);
        }

        [HttpPut("{id}")]
        public ActionResult<Turno> Update(int id, [FromBody] Turno turnoActualizado)
        {
            var turno = _turnoService.GetById(id);
            if (turno == null)
                return NotFound();

            
            turno.PacienteId = turnoActualizado.PacienteId;
            turno.ProfesionalId = turnoActualizado.ProfesionalId;
            turno.Estado = turnoActualizado.Estado;

            return Ok(turno);
        }


        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var turno = _turnoService.GetById(id);
            if (turno == null)
                return NotFound();

            _turnoService.Delete(id);
            return NoContent();
        }
    }
}
