using GeometricCalculator.Abstract;
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
