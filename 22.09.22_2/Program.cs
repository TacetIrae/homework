void FillArray(int[] array, int x)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = x + i;
    }

}
Console.WriteLine("Enter min value");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Enter max value");
int y = int.Parse(Console.ReadLine());

int[] array = new int[y - x+1];
FillArray(array, x);

Console.WriteLine($"{array.Sum()}");