
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

int minSumRow = 0;

int sumRow = SumOfRow(myArray, 0);

for (int i = 1; i < myArray.GetLength(0); i++)
{
    int tempSumLine = SumOfRow(myArray, i);
    if (sumRow > tempSumLine)
    {
        sumRow = tempSumLine;
        minSumRow = i;
    }
}

Console.WriteLine($"{minSumRow + 1} - row with the least sum = ({sumRow})  ");


int SumOfRow(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
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
            Console.Write(array[i, j] + ",");
        }
        Console.WriteLine();
    }
}

