Console.WriteLine("Enter a 5 digit number");
string number = Console.ReadLine();

if (number[0] == number[4])
{
    if (number[1] == number[3])
    {
        Console.WriteLine("Полиндром");
    }
    else
    {
        Console.WriteLine("Не Полиндром");
    }
}
else
{
    Console.WriteLine("Не полиндром");
}