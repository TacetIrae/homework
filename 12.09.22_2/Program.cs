double b1, b2, k1, k2;

Console.WriteLine("Write b1 coordinate");
b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Write b2 coordinate");
b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Write k1 coordinate");
k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Write k2 coordinate");
k2 = double.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);

Console.WriteLine($"The result is: {x} ; {k1*x+b1}");