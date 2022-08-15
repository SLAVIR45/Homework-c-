Console.Clear();


void Lesson_41()
{
    //Пользователь вводит с клавиатуры M чисел.
    // Посчитайте, сколько чисел больше 0 ввёл пользователь.

    Console.WriteLine("Enter the number of digits");
    int number_of = Convert.ToInt32(Console.ReadLine());
    int count = 0;

    for (int i = 0 ; i <= number_of; i++)
    {
        Console.WriteLine("Enter the number");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0 ) 
        count++;
    }
    Console.WriteLine($"Out of {number_of} numbers,  numbers {count} are greater than 0");
}


void Lesson_43()
{
    // Напишите программу, которая найдёт точку пересечения двух прямых, 
    //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
    //значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Enter the b1");
double b1= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the k1");
double k1= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the b2");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the k2");
double k2= Convert.ToInt32(Console.ReadLine());

if (k1 == k2) Console.WriteLine("прямые параллельны");
else
{
    double x0 = (b2 -b1) / (k1-k2);
    double y0 = (k1 * x0)  + b1;
    Console.WriteLine($"точка пересечения прямых {x0}; {y0}");
}
}





//Lesson_41();
//Lesson_43();