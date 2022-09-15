int[,] myArray = { { 1, 55, 3,4 }, { 3, 5, 3,4 }, { 5, 3, 1,4 }, { 123, 234, 345,4 } };

for (int i = 0; i < myArray.GetLength(0); i++)
{
    int avarageAritch = 0;

    for (int t = 0; t < myArray.GetLength(1); t++)
    {
        avarageAritch += myArray[i, t];
    }
    Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)avarageAritch / 4}");
 
}

