using AreaFigure.Common.Abstract;
using AreaFigure.Common.Shapes;
using AreaFigureWebApi.Helpers;
using AreaFigureWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AreaFigureWebApi.Controllers
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
