using ViolacionLSP;

FiguraGeometrica figura = new FiguraGeometrica(30,60);
Rectangulo rectangulo = new Rectangulo(5,4);
Cuadrado cuadrado = new Cuadrado(25);


Console.WriteLine($"Calcular el valor de la figura Geometrica: {figura.BBase * figura.Altura}");
Console.WriteLine($"Calcular el valor del rectangulo: {rectangulo.CalcularArea()}");
Console.WriteLine($"Calcular el valor del cuadrado: {cuadrado.CalcularArea()}");


