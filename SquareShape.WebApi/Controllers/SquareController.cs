using GeometryCalculator.Abstract;
using Microsoft.AspNetCore.Mvc;
using SquareShape.WebApi.Helpers;
using SquareShape.WebApi.Models;

namespace SquareShape.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SquareController : ControllerBase
    {
        private readonly IMakerFigures _figureManager;
        public SquareController(IMakerFigures figureManager)
        {
            _figureManager = figureManager;
        }

        public IActionResult Get()
        {
            var welcome = "Enter the parameters of the figure \nJSON format: \n{\r\n    \"values\" : [double, ...]\r\n})";
            return new ObjectResult(welcome);
        }

        [HttpPost]
        public IActionResult Create([FromBody] InputValuesFigure item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            var shape = _figureManager.Create(item.Values);
            var figureInfo = Mapping.ToInformAboutFigure(shape);
            return new ObjectResult(figureInfo);
        }
    }
}
