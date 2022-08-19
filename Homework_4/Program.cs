Console.WriteLine("Enter a number");
int number;
bool a = true;
string choice = "";
if (int.TryParse(Console.ReadLine(), out number))
{
    for (int i = 1; i < number+1; i++)
    {
        while (a)
        {
            Console.WriteLine("Which list of integers you want to output. Even or odd");
            choice = Console.ReadLine().ToLower();
            if (choice == "odd"|| choice == "even")
            {
                a = false;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        if (choice == "even")
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                continue;
            }

        }
        else if (choice =="odd")
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                continue;
            }
        }
    }
}
else
{
    Console.WriteLine("Invalid input");
}