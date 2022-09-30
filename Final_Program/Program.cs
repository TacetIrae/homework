Console.WriteLine("Please enter the size of the array");
int size = int.Parse(Console.ReadLine());
string[] myArray = new string[size];





void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Enter {i} position in array");
        array[i] = Console.ReadLine(); 
    }
}

