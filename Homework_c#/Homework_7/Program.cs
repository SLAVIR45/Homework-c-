Console.Clear();

void Lesson_47()
{
    /*
    Задайте двумерный массив размером m×n, 
    заполненный случайными вещественными числами.
    */

    Console.WriteLine("Eenter the number of rows");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("enter the number of columns");
    int columns = Convert.ToInt32(Console.ReadLine());

    double [,] array = new double [rows,columns];
    random_double_array(array,-10,10);
    print_double_array(array);
}


void random_double_array (double[,] array, int start_number = -20 , int finish_number = 20)
{   
    finish_number++;
    Random rand = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    
    for (int i = 0 ; i < rows; i++)
    {
        for (int j = 0 ; j < columns; j++)
        {
            array[i,j] = rand.NextDouble() * (finish_number - start_number) + start_number;
        }
    }
}


void print_double_array (double [,] array)
{
    Console.WriteLine ("Array:");
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    
    for (int i = 0 ; i < rows; i++)
    {
        for (int j = 0 ; j < columns; j++)
        {
             Console.Write (Math.Round(array[i,j], 2) + "\t" );
        }
         Console.WriteLine();
    }
    
}






void random_array (int[,] array, int start_number = -20 , int finish_number = 20)
{   
    finish_number++;
    Random rand = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    
    for (int i = 0 ; i < rows; i++)
    {
        for (int j = 0 ; j < columns; j++)
        {
            array[i,j] = rand.Next(start_number, finish_number);
        }
    }
}

void print_array (int [,] array)
{
    Console.WriteLine ("Array:");
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    
    for (int i = 0 ; i < rows; i++)
    {
        for (int j = 0 ; j < columns; j++)
        {
             Console.Write (array[i,j] + "\t" );
        }
         Console.WriteLine();
    }
    
}

Lesson_47();