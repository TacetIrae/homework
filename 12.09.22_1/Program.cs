Console.WriteLine("How many numbers you want to enter?");
int arraycCount = int.Parse(Console.ReadLine());
int[] myArray = new int[arraycCount];
Console.WriteLine("Now please type those numbers one after another");
for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine($"Please enter {i} number");
    myArray[i] = int.Parse(Console.ReadLine());

}

int[] result = Array.FindAll(myArray, i => i > 0);
Console.WriteLine($"Number of numbers higher than 0 is:{result.Length}");
