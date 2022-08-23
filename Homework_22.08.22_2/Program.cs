Console.WriteLine("Input a number");
int number = int.Parse(Console.ReadLine());
string num = Convert.ToString(number);

try
{
    Console.WriteLine(num[2]);
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine($"This number {number}, does not have third value");
}