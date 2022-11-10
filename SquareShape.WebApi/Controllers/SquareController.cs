using AutoMapper;
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
        private readonly IMapper _mapper;
        public SquareController(IMakerFigures figureManager, IMapper mapper)
        {
            _figureManager = figureManager;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Create([FromBody] InputValuesFigure item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            var shape = _figureManager.Create(item.Values);
            var figureInfo = _mapper.Map<IFigure>(shape);
            return new ObjectResult(figureInfo);
        }
    }
}
