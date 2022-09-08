int sumOfEvenNumbers(int[] myarray)
{
    int evenNumbersSum = 0;
    for (int i = 0; i < myarray.Length; i++)
    {
        if (myarray[i]%2 == 1)
        {
            evenNumbersSum += myarray[i];
        }
    }
    return evenNumbersSum;
}

int FillArray (int array)
{
    array = new Random().Next(1, 100);
    return array;
}

int[] myarray = new int[10];
for (int i = 0; i < myarray.Length; i++)
{
    myarray[i] = FillArray(myarray[i]);
}

Console.WriteLine(sumOfEvenNumbers(myarray));