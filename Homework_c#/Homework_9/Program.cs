Console.Clear();



void Lesson_64 ()
{
     /*
    Задайте значения M и N. Напишите программу, 
    которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
    */

    Console.WriteLine("Enter the number m");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the number n");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write ("Числа кратные 3: ");
    Recurcia (m,n);
}

void Recurcia (int m , int n )
    {
        if ( m > n) return;
        if (m % 3 == 0)
        Console.Write (m + ", ");
        m++;
        Recurcia(m,n);
    }



Lesson_64 ();