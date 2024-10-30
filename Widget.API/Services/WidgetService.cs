using Microsoft.AspNetCore.Mvc;
using Widget.API.Repository;

namespace Widget.API.Services;

public class WidgetService
{
    private readonly WidgetRepository _widgetRepository = new();

    public IActionResult GetWidget(int id)
    {
        var widget = _widgetRepository.GetWidget(id);
        return new OkObjectResult(widget);
    }

    public void CreateWidget(Model.Widget value)
    {
        switch (DateTime.Now.DayOfWeek)
        {
            case DayOfWeek.Saturday:
            case DayOfWeek.Sunday:
                value.IsWeekendSale = true;
                break;
            case DayOfWeek.Monday:
                break;
            case DayOfWeek.Tuesday:
                break;
            case DayOfWeek.Wednesday:
                break;
            case DayOfWeek.Thursday:
                break;
            case DayOfWeek.Friday:
                break;
            default:
                value.IsWeekendSale = false;
                break;
        }

        _widgetRepository.Add(value);
    }

    public IActionResult GetWidgets()
    {
        var widgets = _widgetRepository.GetWidgets();
        return new OkObjectResult(widgets);
    }
}