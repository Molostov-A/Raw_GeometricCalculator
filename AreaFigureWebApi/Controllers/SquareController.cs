using SquareShape.Common.Abstract;
using SquareShape.Common.Shapes;
using Microsoft.AspNetCore.Mvc;
using SquareShape.WebApi.Helpers;
using SquareShape.WebApi.Models;

namespace SquareShape.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SquareController : ControllerBase
    {
        private readonly IStrategyShape<Shape> _figureManager;
        public SquareController(IStrategyShape<Shape> figureManager)
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
            _figureManager.Create(item.Values);
            var shape = _figureManager.GetShape();
            var figureInfo = Mapping.ToInformAboutFigure(shape);
            return new ObjectResult(figureInfo);
        }
    }
}
