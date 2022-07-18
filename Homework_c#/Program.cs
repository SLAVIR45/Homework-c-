Console.Clear();
/*
Lesson_10 (Задача 10: Напишите программу, которая принимает на вход 
 трёхзначное число и на выходе показывает вторую цифру этого числа.)

Lesson_13 (Напишите программу, которая с помощью деления 
    выводит третью цифру заданного числа или сообщает, что третьей цифры нет.)
*/


void Lesson_10()
{
/*
 Задача 10: Напишите программу, которая принимает на вход 
 трёхзначное число и на выходе показывает вторую цифру этого числа.
*/

Random rand = new Random();
int num = rand.Next(100, 1000);
Console.WriteLine(num);

int Hundredths = num / 100;
int Untis = num % 100 / 10;
int Tens = num % 100 % 10;

Console.WriteLine(Untis);
}


void Lesson_13()
{
/*
    Напишите программу, которая с помощью деления 
    выводит третью цифру заданного числа или сообщает, 
    что третьей цифры нет.
 */

Console.WriteLine("Enter number");
int num = Convert.ToInt32(Console.ReadLine());
int Tens;

if (num / 100 > 0) 
{
    Console.WriteLine(Tens = num % 100 % 10);
}
 else 
{
    Console.WriteLine("The third numbers is missing");  
}
}

void Lesson_15()
/*
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
*/

Console.WriteLine("Enter number");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0 && num <= 7)
    
     if  (num == 6 || num == 7) 
     Console.WriteLine(num + " Weekend");
     else
     Console.WriteLine(num + " Working day");

else 
Console.WriteLine(num + " is not a number of the week");