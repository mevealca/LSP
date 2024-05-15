using LSP;

FiguraGeometrica rectangulo = new Rectangulo(25,58);
FiguraGeometrica cuadrado = new Cuadrado(25);



Console.WriteLine($"Calcular el valor del rectangulo: {rectangulo.CalcularArea()}");
Console.WriteLine($"Calcular el valor del cuadrado: {cuadrado.CalcularArea()}");