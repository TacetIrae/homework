void AtoThePowerOfB ()
{
    bool decision = true;

    while (decision)
    {
        Console.WriteLine("Enter first number");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int number2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"The result is: {Math.Pow(number1,number2)}");
        Console.WriteLine("Do you want to repeat a process? Type no in case you want to stop");
        string dec = Console.ReadLine().ToLower();
        if (dec == "no")
        {
            decision = false;
        }
    }


}

AtoThePowerOfB();
