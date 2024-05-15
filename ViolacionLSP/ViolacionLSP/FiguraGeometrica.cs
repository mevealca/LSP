namespace ViolacionLSP
{
    public class FiguraGeometrica
    {
        public decimal BBase { get; set; }
        public decimal Altura { get; set; }

        public FiguraGeometrica(decimal bBase, decimal altura)
        {
            BBase = bBase;
            Altura = altura;
        }
    }
}
