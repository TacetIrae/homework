int[,] myArray = { { 1, 2 , 3 , 4 }, { 5, 7 , 9 ,12 }, { 10, 15,20,27 }, { 20, 25,30,40 } };


Console.WriteLine("Enter a coordinate of a number in an array?");

Console.WriteLine("Which row?");

int a = int.Parse(Console.ReadLine());

Console.WriteLine("Which coloum?");

int b = int.Parse(Console.ReadLine());


if (a > 0 || a < 4)
{
    if (b > 0 || b < 4)
    {
        Console.WriteLine($"Data unders this index:{a},{b} is : {myArray[a,b]}");
    }
    else Console.WriteLine("Out of reach index");
}
else
{
    Console.WriteLine("Out of reach index");
}