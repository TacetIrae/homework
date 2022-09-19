Console.WriteLine($"Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.\n\nСразу зададим матрицу, которую можно перемножить, т.е. количество столбцов первой равно количеству строк второй");
Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");

Console.WriteLine("Number of rows for first matrix: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Number of colums for first matrix: ");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("Number of rows for the second matrix");
int j = int.Parse(Console.ReadLine());

Console.WriteLine("Number of colums for the second matrix: ");
int z = int.Parse(Console.ReadLine());

Console.WriteLine("Range of numbers from 1 to: ");
int range = int.Parse(Console.ReadLine());

int[,] firstMartrix = new int[x, y];
FillArray(firstMartrix);
Console.WriteLine("First matrix");
PrintArray(firstMartrix);

int[,] secomdMartrix = new int[j, z];
FillArray(secomdMartrix);
Console.WriteLine("Second matrix");
PrintArray(secomdMartrix);

int[,] multipliedMatrix = new int[x,z];

MultiplyMatrix(firstMartrix, secomdMartrix, multipliedMatrix);
Console.WriteLine("Result of multiplication between first and second matrix:");
PrintArray(multipliedMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] multipliedMatrix)
{
    for (int i = 0; i < multipliedMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multipliedMatrix.GetLength(1); j++)
        {
            int sum = 0;

            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            multipliedMatrix[i, j] = sum;
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
            Console.Write(array[i, j] + ",");
        }
        Console.WriteLine();
    }
}