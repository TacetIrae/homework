void ArrayProcess()
{
    int[] myArray = new int[8];
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(1, 100);
    }
    foreach (int i in myArray)
    {
        Console.WriteLine(i);
    }
}


ArrayProcess();