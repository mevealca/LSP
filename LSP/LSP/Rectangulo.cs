namespace LSP
{
    public class Rectangulo: FiguraGeometrica
    {
        public decimal BBase { get; set; }
        public decimal Altura { get; set; }

        public Rectangulo(decimal bbase, decimal altura) { 
            
            this.BBase = bbase;
            this.Altura = altura;
        
        }
        public override decimal CalcularArea()
        {
            return BBase * Altura;
        }
    }
}
