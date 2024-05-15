namespace ViolacionLSP
{
    public class Rectangulo : FiguraGeometrica
    {
        public Rectangulo(decimal bBase, decimal altura) : base(bBase, altura)
        {
        }

        public decimal CalcularArea() {

            return BBase * Altura;
        }
        
    }
}
