int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine("Enter m value");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter n value");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"The result is: {Akkerman(m,n)}");

