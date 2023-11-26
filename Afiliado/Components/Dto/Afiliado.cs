namespace Afiliado.Components.Dto
{
    public class Afiliado
    {
        public required string Username { get; set; }
        public required string Img { get; set; }
        public required DateTime FechaRegistro { get; set; }
        public required decimal Gastos { get; set; }
        public decimal CincoPorCientoGastos => Gastos * 0.05m;
    }

    public static class AfiliadoList
    {
        public static List<Afiliado> GetColors()
        {
            return new List<Afiliado>
            {
                new Afiliado { Username = "user123", Img = "img/user123.jpg", FechaRegistro = new DateTime(2022, 5, 10), Gastos = 500 },
                new Afiliado { Username = "johndoe", Img = "img/johndoe.jpg", FechaRegistro = new DateTime(2023, 1, 15), Gastos = 1200 },
                new Afiliado { Username = "alice95", Img = "img/alice95.jpg", FechaRegistro = new DateTime(2023, 7, 20), Gastos = 800 },
                new Afiliado { Username = "testuser", Img = "img/testuser.jpg", FechaRegistro = new DateTime(2023, 10, 5), Gastos = 300 },
                new Afiliado { Username = "coolgamer", Img = "img/coolgamer.jpg", FechaRegistro = new DateTime(2022, 11, 30), Gastos = 1500 },
                new Afiliado { Username = "newuser", Img = "img/newuser.jpg", FechaRegistro = new DateTime(2023, 3, 18), Gastos = 700 },
                new Afiliado { Username = "happycoder", Img = "img/happycoder.jpg", FechaRegistro = new DateTime(2022, 8, 25), Gastos = 2000 },
                new Afiliado { Username = "booklover", Img = "img/booklover.jpg", FechaRegistro = new DateTime(2023, 5, 9), Gastos = 100 },
                new Afiliado { Username = "travelbug", Img = "img/travelbug.jpg", FechaRegistro = new DateTime(2022, 12, 12), Gastos = 900 },
                new Afiliado { Username = "fitnessfreak", Img = "img/fitnessfreak.jpg", FechaRegistro = new DateTime(2023, 8, 7), Gastos = 1300 },
            };
        }
    }
}
