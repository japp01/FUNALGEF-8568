namespace AlquilerDeCarros
{
    public class Alquiler
    {
        public int Numero { get; set; }
        public Carro CarroAlq { get; set; }
        public Cliente Contratante { get; set; }
        public double Precio { get; set; }

        public override string ToString()
        {
            return $"Alquiler #{Numero}, {CarroAlq}, Cliente: {Contratante.Nombre}, Precio: {Precio:C}";
        }
    }
}
