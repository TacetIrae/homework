int number;

Console.WriteLine("Please enter a number");

if (int.TryParse(Console.ReadLine(), out number))
{
    int result = number % 2;

    if (result == 0)
    {
        Console.WriteLine("Your number is even");
    }
    else if (result == 1)
    {
        Console.WriteLine("Yout number is odd");

    }
    else
    {
        Console.WriteLine("You did something wrong");
    }
 
}

else
{
    Console.WriteLine("Invalid input");
}