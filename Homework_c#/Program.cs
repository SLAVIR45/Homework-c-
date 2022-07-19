Console.Clear();




void Lesson_2()
{
/*
 Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее
*/


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
}

void Lesson_4()
{
/*
Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.
*/


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
}

void Lesson_6()
{
/*
Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
*/


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
}

void Lesson_8()
{
/*
Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.
*/

Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("list of even numbers: "); 
for ( int i = 1 ; i<=number ; i++ )
     {
        if (i % 2 == 0)
        {
            Console.Write(i + " "); 
        }

     }
}


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
num = Math.Abs(num);
if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else 
 {
    while (num > 999)
    {   
    num /= 10;
    }
    Console.WriteLine("Третья цифра числа: " + num %10);
}
}


void Lesson_15()
{
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
}




Lesson_13();
