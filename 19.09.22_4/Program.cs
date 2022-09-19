Console.WriteLine($"Enter size of an array via values of x and y and z:");

Console.WriteLine("Enter x:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Enter y:");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("Enter z: ");
int z = int.Parse(Console.ReadLine());

int[,,] my3dArray = new int[x, y, z];

FillArray(my3dArray);
PrintArray(my3dArray);

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"x({i}) y({j}) z({k})={array[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void FillArray(int[,,] array)
{
    int[] TempArray = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int number;
    for (int i = 0; i < TempArray.GetLength(0); i++)
    {
        TempArray[i] = new Random().Next(10, 100);
        number = TempArray[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (TempArray[i] == TempArray[j])
                {
                    TempArray[i] = new Random().Next(10, 100);
                    j = 0;
                    number = TempArray[i];
                }
                number = TempArray[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = TempArray[count];
                count++;
            }
        }
    }
}
