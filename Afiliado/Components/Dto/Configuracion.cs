namespace Afiliado.Components.Dto
{
    public class Configuracion
    {
        public Colors Color { get; set; }
        public string Logo { get; set; }

        public Configuracion()
        {
            Color = ColorList.GetColors().First();
            Logo = "./img/Logo_cirsa.png";
        }
    }
}
