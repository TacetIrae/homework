void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Enter {i} position in array");
        array[i] = Console.ReadLine(); 
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ "  ");
    }
}


void SortArray (string[] array)
{
    int NewArrayLength = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int length = array[i].Length;
        if (length > 0 && length < 4)
        {
            NewArrayLength += 1;
        }

    }
    string[] TempArray = new string[NewArrayLength];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length > 0 && array[i].Length < 4)
        {
            TempArray[count] = array[i];
            count += 1;
        }

    }
    Console.Write("--->");
    PrintArray(TempArray);

}


Console.WriteLine("Please enter the size of the array");
int size = int.Parse(Console.ReadLine());
string[] myArray = new string[size];

FillArray(myArray);
PrintArray(myArray);
SortArray(myArray);
