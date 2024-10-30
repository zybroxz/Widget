using Microsoft.AspNetCore.Mvc;
using Widget.API.Model;



namespace Widget.API.Repository
{

    public class WidgetRepository
    {
        private static readonly List<Model.Widget> Widgets = new();

        public void Add(Model.Widget value) 
            => Widgets.Add(value);

        public Model.Widget? GetWidget(int id)
        {
            var widget = Widgets.Find(w => w.Id == id);
            return widget;
        }

        public List<Model.Widget> GetWidgets() 
            => Widgets;
    }
}