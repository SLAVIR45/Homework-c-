Console.Clear();
Console.WriteLine("Enter the first number");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number");
int numberSecond = Convert.ToInt32(Console.ReadLine());

if (numberOne > numberSecond) 
{
    Console.WriteLine("max = " + numberOne + " " + "min = " + numberSecond);
}
else
    Console.WriteLine("max = " + numberSecond + " " + "min = " + numberOne);