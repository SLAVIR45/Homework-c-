﻿/*
Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.
*/

Console.Clear();

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
