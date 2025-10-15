using Microsoft.AspNetCore.Mvc;

namespace ColoresApiPrueba.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColorsController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var colors = new List<ColorDto>
        {
            new(1, "Rojo",    "#FF0000"),
            new(2, "Verde",   "#00FF00"),
            new(3, "Azul",    "#0000FF"),
            new(4, "Amarillo","#FFFF00"),
            new(5, "Negro",   "#000000"),
            new(6, "Blanco",  "#FFFFFF"),
        };

            return Ok(colors);
        }
    }
    public record ColorDto(int Id, string Nombre, string Hex);
}
