int[,] myarray = new int[4, 4];

int step = 1;
int i = 0;
int j = 0;

while (step <= myarray.GetLength(0) * myarray.GetLength(1))
{
    myarray[i, j] = step;
    step++;
    if (i <= j + 1 && i + j < myarray.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= myarray.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > myarray.GetLength(1) - 1)
        j--;
    else
        i--;
}

PrintArray(myarray);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write(array[i, j]+" ");
            else Console.Write(array[i, j] + " ");

        }
        Console.WriteLine();
    }
}

