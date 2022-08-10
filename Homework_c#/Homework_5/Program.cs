Console.Clear();


void Lesson_34()
{
    int size = 5;
    int [] array = new int [size];
    random_array(array, 100 , 999);
    print_array (array);
    number_of_even_numbers(array);
} 

Lesson_34 ();


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