Console.Clear();


void Lesson_34()
/*
Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
*/
{
    int size = 5;
    int [] array = new int [size];
    random_array(array, 100 , 999);
    print_array (array);
    number_of_even_numbers(array);
} 

void Lesson_36()
/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
*/
{
    int size = 5;
    int [] array = new int [size];
    random_array(array);
    print_array (array);
    sum_of_digits_in_odd_positions(array);
}


void Lesson_38()
/*
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
*/
{
    int size = 5;
    double [] array = new double [size];
    random_array_of_real_numbers(array);
    print_array_real(array);
    the_difference_between_min_and_maximum(array);
}



void the_difference_between_min_and_maximum (double [] arr) // разница между мах и мин
{
    double min = arr[0];
    double max = arr [0];
    for (int i = 1 ; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        else if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    Console.WriteLine($"разница между максимальным {Math.Round(max,2)} и минимальным {Math.Round(min,2)} элементом массива = {Math.Round(max-min,2)}");
}




void sum_of_digits_in_odd_positions (int[] arr) //сумма цифр в нечетных позициях
{
    int sum = 0;
    for (int i = 0 ; i < arr.Length; i++)
    {
        if ( i % 2 == 1) 
        {
            sum += arr[i];
        }
    }
    Console.WriteLine($"сумма элементов, стоящих на нечётных позициях = {sum}");
}


void number_of_even_numbers (int[] arr) //колличество четных чисел в массиве
{
    int count = 0;
    for (int i = 0 ; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) 
        {
            count++;
        }
    }
    Console.WriteLine($"колличество чётных чисел в массиве = {count}");
}    



void random_array (int[] arr, int start_number = -20 , int finish_number = 20)
{   
    finish_number++;
    Random rand = new Random();
    for (int i = 0 ; i < arr.Length; i++)
    {
        arr [i] = rand.Next(start_number, finish_number);
    }
}

void print_array (int [] arr)
{
    Console.WriteLine ("Array:");
    for (int i = 0 ; i < arr.Length; i++)
    {
        Console.Write (arr[i] + " ");
    }
    Console.WriteLine ();
}


void print_array_real (double [] arr) //печать вещественного массива
{
    Console.WriteLine ("Array:");
    for (int i = 0 ; i < arr.Length; i++)
    {
        Console.Write ("["+ Math.Round(arr[i],2) + "] ");
    }
    Console.WriteLine ();
}


void random_array_of_real_numbers(double [] arr, int start_number = -100 , int finish_number = 100)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.NextDouble() * (finish_number - start_number) + start_number; 
    }
}



Lesson_34();
//Lesson_36();
//Lesson_38();