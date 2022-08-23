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
    Recurcia_64 (m,n);
}

void Lesson_66 ()
{
     /*
     Задайте значения M и N. Напишите программу, 
     которая найдёт сумму натуральных элементов в промежутке от M до N.
    */

    Console.WriteLine("Enter the number m");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the number n");
    int n = Convert.ToInt32(Console.ReadLine());
   
    Recurcia_66 (m,n);
    Console.Write ($"Сумма чисел от {m} до {n}: {Recurcia_66(m,n)} ");
}



void Lesson_68 ()
{
     /*
     Напишите программу вычисления функции Аккермана с помощью рекурсии. 
     Даны два неотрицательных числа m и n.
    */

    Console.WriteLine("Enter the number m");
    long m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the number n");
    long n = Convert.ToInt32(Console.ReadLine());

    A (m,n);
    Console.WriteLine($"Функция Аккермана = {A (m,n)}");
}









int Recurcia_66 (int m , int n , int sum = 0)
    {
        if ( m > n) return sum ;
        sum += m;
        m ++;
        return Recurcia_66(m,n, sum);
       
    }

void Recurcia_64 (int m , int n )
    {
        if ( m > n) return;
        if (m % 3 == 0)
        Console.Write (m + ", ");
        m++;
        Recurcia_64(m,n);
    }

 long A (long m, long n)
 {
    if (m == 0)
    {
        return n + 1;
    }
     else if (n == 0)
    {
        return A(m - 1, 1);
    }
    else
    {
        return A(m - 1, A(m, n - 1));
    }
 }

//Lesson_64 ();
//Lesson_66 ();
Lesson_68 ();