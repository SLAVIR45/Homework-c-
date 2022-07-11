/*
Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
*/

Console.Clear();

Console.WriteLine("Enter the first number");
int numberOne = Convert.ToInt32(Console.ReadLine());

if (numberOne % 2 == 0)
{
    Console.WriteLine("Number " + numberOne + " even");
}
else
{
    Console.WriteLine("Number " + numberOne + " odd");
}