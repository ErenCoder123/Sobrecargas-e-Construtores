Retangulo r1 = new Retangulo();
Retangulo r2 = new Retangulo(5);
Retangulo r3 = new Retangulo(4, 6);

Console.WriteLine($"A área do retangulo r1 é igual a: {r1.CalcularArea()}");
Console.WriteLine($"O períemtro do retangulo r1 é igual a: {r1.CalcularPerimetro()}");


Console.WriteLine($"A área do retangulo r2 é igual a: {r2.CalcularArea()}");
Console.WriteLine($"O períemtro do retangulo r2 é igual a: {r2.CalcularPerimetro()}");


Console.WriteLine($"A área do retangulo r3 é igual a: {r3.CalcularArea()}");
Console.WriteLine($"O períemtro do retangulo r3 é igual a: {r3.CalcularPerimetro()}");


r3.Redimensionar(2);
Console.WriteLine($"A área do retangulo r3 é igual a: {r3.CalcularArea()}");
Console.WriteLine($"O períemtro do retangulo r3 é igual a: {r3.CalcularPerimetro()}");

r2.Redimensionar(10, 15);
Console.WriteLine($"A área do retangulo r2 é igual a: {r2.CalcularArea()}");
Console.WriteLine($"O períemtro do retangulo r2 é igual a: {r2.CalcularPerimetro()}");
