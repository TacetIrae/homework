int SumOfNumbers()
{
    Console.WriteLine("Enter a number");
    int num = int.Parse(Console.ReadLine());
    int sum = 0;

    while (num >= 10)
    {
        sum += num % 10;
        num /= 10;
    }
    sum += num;
  
    return sum;
}


Console.WriteLine(SumOfNumbers());