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
        
    if  (num == 6 || num == 7) 
        Console.WriteLine(num + " Weekend");
    else if (num >= 1 && num <=5)
        Console.WriteLine(num + " Working day");

    else 
    Console.WriteLine(num + " is not a number of the week");
}


void Lesson_19()
{
    /*
    Напишите программу, которая принимает на вход пятизначное 
    число и проверяет, является ли оно палиндромом.
    */
    
    
    Console.WriteLine("Enter five-digit number");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num > 9999 && num < 100000)
    {
        int one = num / 10000;
        int two = num / 1000 % 10;
        //int three = num / 100 % 10;
        int four = num / 10 % 10;
        int five = num % 10; 
         if (one == five && two == four)
        {
            Console.WriteLine("number: " + num + " Palindrome");
        }   
            else
            {
                Console.WriteLine("number: " + num + "  is not Palindrome");
            }
    }
     else  
     {
        Console.WriteLine("number is not five-digit");
     }
}


void Lesson_21()
{
    /*
    Напишите программу, которая принимает на вход координаты 
    двух точек и находит расстояние между ними в 3D пространстве.
    */

    Console.WriteLine("Enter the coordinates of first point");
    int x1 = Convert.ToInt32(Console.ReadLine());
    int y1 = Convert.ToInt32(Console.ReadLine());
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"point one: [{x1};{y1};{z1}]");

    Console.WriteLine("Enter the coordinates of second point");
    int x2 = Convert.ToInt32(Console.ReadLine());
    int y2 = Convert.ToInt32(Console.ReadLine());
    int z2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"point two: [{x2};{y2};{z2}]");

    int xx =  (x2 - x1);
    int yy =  (y2 - y1);
    int zz =  (z2 - z1);


    double distance = Math.Sqrt(Math.Pow(xx, 2) +
                                Math.Pow(yy, 2) +
                                Math.Pow(zz, 2));
    double otvet = Math.Round(distance,2);
    Console.WriteLine($"\nDistanse = {otvet}");
    
}


void Lesson_23()
{
/*
Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N.
*/

    Console.WriteLine("Enter five-digit number");
    int num = Convert.ToInt32(Console.ReadLine());
    int i = 1;
    

    while ( i <= num)
    {
        double cub = Math.Pow(i, 3);
        Console.Write(cub + " ");
        i++;
    }
}
    

void Lesson_25()
{
/*
Используя определение степени числа, напишите цикл, который принимает на вход 
два натуральных числа (A и B) и возводит число A в степень B.
*/

Console.WriteLine("Enter number one");
int num_one = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number two");
int num_two = Convert.ToInt32(Console.ReadLine());
int step = num_one;
int i = 1;

if (num_two == 0)
    {  
        Console.WriteLine($"число {num_one} в степни {num_two} = 1 ");
    }
else
    {
        while ( i < num_two)
            {
            step = step * num_one;
            i++;
            }
        Console.WriteLine($"число {num_one} в степни {num_two} = {step} ");
    }            
}


void Lesson_27()
{
/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
*/

Console.WriteLine("Enter number ");
int num = Convert.ToInt32(Console.ReadLine());
int temp = num;
int sum = 0;
while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10; 
    }
Console.WriteLine($"сумма цифр числа {temp} = {sum}");

}
Lesson_27();
