namespace ViolacionLSP
{
    public class Cuadrado: FiguraGeometrica
    {
        public Cuadrado(decimal lado) : base(lado, lado) { }
        public decimal CalcularArea() { 

            return BBase * Altura;

        }
    }
}
