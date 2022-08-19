double number_1, number_2;

Console.WriteLine("Enter your first number");
while (!double.TryParse(Console.ReadLine(), out number_1))
{
    Console.WriteLine("Your input for number one is invalid. Please try again.");
    Console.WriteLine("Please enter your number again");


}

Console.WriteLine("Enter your second number");

while (!double.TryParse(Console.ReadLine(), out number_2))
{
    Console.WriteLine("Your input for number two is invalid. Please try again. ");
    Console.WriteLine("Please enter your number again");
}

if (number_1 > number_2)
{
    Console.WriteLine(number_1+" is bigger than "+number_2);
}
else if (number_2 > number_1)
{
    Console.WriteLine(number_2+" is bigger than "+number_1);
}
else
{
    Console.WriteLine("Those numbers equal to each other");
}