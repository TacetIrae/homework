int m, n,count;
Console.WriteLine("Enter min value");
n = int.Parse(Console.ReadLine());
Console.WriteLine("Enter max value");
m = int.Parse(Console.ReadLine());

count = m-n;

for (int i = 0; i < count+1; i++)
{
    int number = n;
    Console.WriteLine($"{n+i}");
}
