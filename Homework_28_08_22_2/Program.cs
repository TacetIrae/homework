int a, a2, a3, b, b2, b3;
Console.WriteLine("Enter coordinates of 2 points in third dimension. They will go accrodingly: x,y,z");
a = int.Parse(Console.ReadLine());
a2 = int.Parse(Console.ReadLine());
a3 = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
b2 = int.Parse(Console.ReadLine());
b3 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(b - a,2) + Math.Pow(b2 - a2,2)  + Math.Pow(b3 - a3,2));
Console.WriteLine("Result are: "+result);

