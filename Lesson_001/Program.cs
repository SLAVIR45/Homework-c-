/*
 Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее
*/

Console.Clear();

Console.WriteLine("Enter the first number");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne > numberTwo) 
{
    Console.WriteLine("max = " + numberOne + " " + "min = " + numberTwo);
}
else
{
    Console.WriteLine("max = " + numberTwo + " " + "min = " + numberOne);
}