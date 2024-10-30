namespace Widget.API.Model
{
    public class Widget
    {
        public string Name { get; }
        public int Id { get; }

        public Widget(string name, int id)
        {
            Name = name;
            Id = id;
        }

    }
}