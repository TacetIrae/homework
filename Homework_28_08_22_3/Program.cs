Console.WriteLine("Write a number");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i < number+1; i++)
{
    Console.WriteLine(Math.Pow(i,3));
}