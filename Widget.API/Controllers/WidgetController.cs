using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Widget.API.Model;
using Widget.API.Services;

namespace Widget.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WidgetController : ControllerBase
    {
        private readonly WidgetService _widgetService = new();

        [HttpGet]
        public IActionResult Get() => _widgetService.GetWidgets();

        [HttpGet("{id}")]
        public IActionResult Get(int id) => _widgetService.GetWidget(id);

        [HttpPost]
        public IActionResult Post(Model.Widget widget)
        {
            _widgetService.CreateWidget(widget);
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
