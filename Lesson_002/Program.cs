/*
Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.
*/

Console.Clear();

Console.WriteLine("Enter the first number");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third number");
int numberThree = Convert.ToInt32(Console.ReadLine());

if (numberTwo < numberOne && numberOne > numberThree)
{
    Console.WriteLine("max = " + numberOne);
}
else if (numberOne < numberTwo && numberTwo > numberThree)
{
    Console.WriteLine("max = " + numberTwo);
}
else
{
    Console.WriteLine("max = " + numberThree);
}

   