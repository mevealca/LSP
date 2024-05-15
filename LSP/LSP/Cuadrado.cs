namespace LSP
{
    public class Cuadrado: FiguraGeometrica
    {
        public decimal Lado { get; set; }
        public Cuadrado(decimal lado) {
        
            this.Lado = lado;
        
        }
        public override decimal CalcularArea()
        {
           return Lado * Lado;
        }
    }
}
