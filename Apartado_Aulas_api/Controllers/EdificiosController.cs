using Apartado_Aulas_api.Data.Services;
using Apartado_Aulas_api.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apartado_Aulas_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EdificiosController : ControllerBase
    {
        public EdificiosService _edificiosService;

        public EdificiosController(EdificiosService edificiosService)
        {
            _edificiosService = edificiosService;
        }
        [HttpGet("get-all-edificio")]
        public IActionResult GetAllEdificios()
        {
            var alledificios = _edificiosService.GetAllEdif();
            return Ok(alledificios);
        }

        [HttpGet("get-edificio-by-id/{id}")]
        public IActionResult GetEdificioById(int id)
        {
            var edificio = _edificiosService.GetEdificioById(id);
            return Ok(edificio);
        }

        [HttpPost("add-edificio")]
        public IActionResult AddBook([FromBody] EdificioVM edificio)
        {
            _edificiosService.AddEdificio(edificio);
            return Ok();
        }

        [HttpPut("Update-book-by-id/{id}")]
        public IActionResult UpdateEdificioById(int id, [FromBody]EdificioVM edificio)
        {
            var updateEdificio = _edificiosService.UpdateEdificioByID(id, edificio);
            return Ok(updateEdificio);
        }
        [HttpDelete("Delete-edificio-by-id/{id}")]
        public IActionResult DeleteEdificioById(int id)
        {
            _edificiosService.DeleteEdificioById(id);
            return Ok();
        }

    }
}
