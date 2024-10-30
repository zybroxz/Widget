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
        /// <summary>
        /// Widget service
        /// </summary>
        private readonly WidgetService _widgetService = new();

        /// <summary>
        /// Action to get all widgets
        /// </summary>
        /// <returns>List<Widget></Widget></returns>
        [HttpGet]
        public IActionResult Get() => _widgetService.GetWidgets();

        /// <summary>
        /// Get an individual widget by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Widget</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id) => _widgetService.GetWidget(id);

        /// <summary>
        /// Create a new widget
        /// </summary>
        /// <param name="widget"></param>
        /// <returns>201</returns>
        [HttpPost]
        public IActionResult Post(Model.Widget widget)
        {
            _widgetService.CreateWidget(widget);
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
