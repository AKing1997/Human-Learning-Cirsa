namespace Afiliado.Components.Dto
{
    public class Colors
    {
        public required string Name { get; set; }
        public required string Color { get; set; }
        public required string CssClass { get; set; }
    }

    public static class ColorList
    {
        public static List<Colors> GetColors()
        {
            return new List<Colors>
            {
                new Colors { Name = "Cirsa", Color = "#DCBE68", CssClass = "bg-primary-color" },
                new Colors { Name = "Red", Color = "#FF0000", CssClass = "red-color" },
                new Colors { Name = "Green", Color = "#00FF00", CssClass = "green-color" },
                new Colors { Name = "Blue", Color = "#0000FF", CssClass = "blue-color" },
                new Colors { Name = "Yellow", Color = "#FFFF00", CssClass = "yellow-color" },
                new Colors { Name = "Orange", Color = "#FFA500", CssClass = "orange-color" },
                new Colors { Name = "Purple", Color = "#800080", CssClass = "purple-color" },
                new Colors { Name = "Cyan", Color = "#00FFFF", CssClass = "cyan-color" },
                new Colors { Name = "Magenta", Color = "#FF00FF", CssClass = "magenta-color" }
            };
        }
    }
}
