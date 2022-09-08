using System;

int ArrayEvenOddNumber(int[] marray)

{
    int oddNumberCount = 0;
    for (int i = 0; i < marray.Length; i++)
    {
        if (marray[i] % 2 == 0)
        {
            oddNumberCount += 1;
        }
    }
    return oddNumberCount;
}


int[] myarray = new int[10];

for (int i = 0; i < myarray.Length; i++)
{
    myarray[i] = new Random().Next(100, 1000);
    Console.WriteLine(myarray[i]);
}

Console.WriteLine(ArrayEvenOddNumber(myarray));