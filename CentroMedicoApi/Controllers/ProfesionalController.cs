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
    }
}
