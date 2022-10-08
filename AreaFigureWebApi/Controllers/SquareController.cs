using AreaFigure.Common.Figures;
using AreaFigure.Common.Interface;
using AreaFigureWebApi.Helpers;
using AreaFigureWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AreaFigure.Common.Helpers;

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
            var figure = _figureManager.CreateFigure(item.Values);
            var figureInfo = Mapping.ToInformAboutFigure(figure);
            return new ObjectResult(figureInfo);
        }
    }
}
