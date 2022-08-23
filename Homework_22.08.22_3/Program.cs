Console.WriteLine("Monday = 1");
Console.WriteLine("Tuesday = 2");
Console.WriteLine("Wednsday = 3");
Console.WriteLine("Thursdau = 4");
Console.WriteLine("Friday = 5");
Console.WriteLine("Saturday = 6");
Console.WriteLine("Sunday = 7");
Console.WriteLine("Input a number of a day");
int dayNumber = int.Parse(Console.ReadLine());

    switch (dayNumber)
    {
        case 1:
            Console.WriteLine("It is not a weekend");
            break;
        case 2:
            Console.WriteLine("It is not a weekend");
            break;
        case 3:
            Console.WriteLine("It is not a weekend");
            break;
        case 4:
            Console.WriteLine("It is not a weekend");
            break;
        case 5:
            Console.WriteLine("It is not a weekend");
            break;
        case 6:
            Console.WriteLine("It is  a weekend");
            break;
        case 7:
            Console.WriteLine("It is a weekend");
            break;
        default:
            Console.WriteLine("Wrong input, try again");
            break;
    }