﻿bool loop = true;

while (loop)
{
    double[] myArray = { };
    myArray = new double[3];
    for (int i = 1; i < 4; i++)
    {
        Console.WriteLine("Please enter your " + i +" number");
        myArray[i-1] = double.Parse(Console.ReadLine());

    }
    double max = myArray.Max();
    Console.WriteLine($"The highest number is:"+ max);

    Console.WriteLine("Do you want to try again?");
    Console.WriteLine("If yes type anythig");
    Console.WriteLine("If you want to stop, type 'stop'");

    string decision = Console.ReadLine().ToLower();

   

    if (decision == "stop")
    {
        break;
    }
    else
    {
        continue;
    }
}