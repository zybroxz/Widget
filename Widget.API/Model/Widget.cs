namespace Widget.API.Model
{
    public class Widget
    {
        public string Name { get; }
        public int Id { get; }

        public bool IsWeekendSale { get; set; }

        public Widget(string name, int id, bool wasWeekedSale)
        {
            Name = name;
            Id = id;
            IsWeekendSale = wasWeekedSale;
        }

    }
}