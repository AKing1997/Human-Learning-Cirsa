namespace Afiliado.Components.Dto
{
    public class Afiliado
    {
        public string Username { get; set; }
        public string Img { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal Gastos { get; set; }
        public decimal Ganancia { get; }

        public Afiliado(string username, string img, DateTime fechaRegistro, decimal gastos)
        {
            Username = username;
            Img = img;
            FechaRegistro = fechaRegistro;
            Gastos = gastos;
            Ganancia = gastos * 0.05m;
        }
    }

    public static class AfiliadoList
    {
        public static List<Afiliado> GetAfiliados()
        {
            return new List<Afiliado>
            {
                new Afiliado ("user123", "./img/Persona.jpg", new DateTime(2022, 5, 10), 500 ),
                new Afiliado ("johndoe", "./img/Persona (10).jpeg", new DateTime(2023, 1, 15), 1200),
                new Afiliado ("alice95", "./img/Persona (2).jpg", new DateTime(2023, 7, 20), 800),
                new Afiliado ("testuser", "./img/Persona (3).jpg", new DateTime(2023, 10, 5), 300),
                new Afiliado ("coolgamer", "./img/Persona (4).jpg", new DateTime(2022, 11, 30), 1500),
                new Afiliado ("newuser", "./img/Persona (5).jpg", new DateTime(2023, 3, 18), 700),
                new Afiliado ("happycoder", "./img/Persona (6).jpg", new DateTime(2022, 8, 25), 2000),
                new Afiliado ("booklover", "./img/Persona (7).jpg", new DateTime(2023, 5, 9), 100),
                new Afiliado ("travelbug", "./img/Persona (8).jpg", new DateTime(2022, 12, 12), 900),
                new Afiliado ("fitnessfreak", "./img/Persona (9).jpg", new DateTime(2023, 8, 7), 1300),
            };
        }

        public static List<Afiliado> OrdenarPorGastosDeMayorAMenor()
        {
            return GetAfiliados().OrderByDescending(a => a.Gastos).ToList();
        }

        public static List<Afiliado> OrdenarPorGananciaDeMayorAMenor()
        {
            return GetAfiliados().OrderByDescending(a => a.Ganancia).ToList();
        }

        public static List<Afiliado> OrdenarPorFechaDeRegistroMasNuevos()
        {
            return GetAfiliados().OrderByDescending(a => a.FechaRegistro).ToList();
        }

        public static decimal CalcularSumaTotalGanancias()
        {
            var afiliados = GetAfiliados();
            decimal sumaTotal = afiliados.Sum(a => a.Ganancia);
            return sumaTotal;
        }
    }
}
