using Microsoft.AspNetCore.Mvc;
using Widget.API.Repository;

namespace Widget.API.Services;

public class WidgetService
{
    private readonly WidgetRepository _widgetRepository = new();

    internal IActionResult GetWidget(int id)
    {
        var widget = _widgetRepository.GetWidget(id);
        return new OkObjectResult(widget);
    }

    public void CreateWidget(Model.Widget value) => _widgetRepository.Add(value);

    public IActionResult GetWidgets()
    {
        var widgets = _widgetRepository.GetWidgets();
        return new OkObjectResult(widgets);
    }
}