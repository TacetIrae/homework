Console.WriteLine("Enter size of an array via values of x and y and range of numbers that could be used for an array:");

Console.WriteLine("Enter x:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Enter y:");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a range from 1 to your desired number: ");
int range = int.Parse(Console.ReadLine());

int[,] myArray = new int[x, y];

FillArray(myArray);

PrintArray(myArray);

Console.WriteLine($"\nSorted array: ");

OrderArrayLines(myArray);

PrintArray(myArray);



void OrderArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int swapNum = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = swapNum;
                }
            }
        }
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}