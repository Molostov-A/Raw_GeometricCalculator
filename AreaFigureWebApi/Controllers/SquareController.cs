using AreaFigure.Common.Interface;
using AreaFigureWebApi.Helpers;
using AreaFigureWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AreaFigureWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SquareController : ControllerBase
    {
        private readonly IFigureManager _figureManager;
        public SquareController(IFigureManager figureManager)
        {
            _figureManager = figureManager;
        }

        [HttpPost]
        public IActionResult Create(InputValuesFigure item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            var figure = _figureManager.CreateFigure(item.Values);
            return new ObjectResult(Mapping.ToInformAboutFigure(figure));
        }
    }
}
