using CentroMedicoApi.Interfaces;
using CentroMedicoApi.Models;
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
    }
}
