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
        private readonly ICentroMedicoService _centroService;

        public CentroMedicoController(ICentroMedicoService centroService)
        {
            _centroService = centroService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CentroMedico>> GetAll()
        {
            return Ok(_centroService.GetAll());
        }

        [HttpPost]
        public ActionResult<CentroMedico> Add(CentroMedico centro)
        {
            var nuevo = _centroService.Add(centro);
            return CreatedAtAction(nameof(GetAll), new { id = nuevo.Id }, nuevo);
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

     

    

}
