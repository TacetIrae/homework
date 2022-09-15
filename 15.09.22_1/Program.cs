int arrayRaws, arrayColums;
Console.WriteLine("How many raws do you want?");
arrayRaws = int.Parse(Console.ReadLine());
Console.WriteLine("How many colums do you want?");
arrayColums = int.Parse(Console.ReadLine());


int [,] FillArray(int [,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-9, 10);
            
        }
       
    }
    return array;
 

}


int[,] EmptyArray = new int[arrayRaws, arrayColums];

int[,] filledArray = FillArray(EmptyArray);

for (int i = 0; i < filledArray.GetLength(0); i++)
{
    for (int j = 0; j < filledArray.GetLength(1); j++)
    {
        Console.WriteLine(filledArray[i,j]);
    }
    Console.WriteLine();
}