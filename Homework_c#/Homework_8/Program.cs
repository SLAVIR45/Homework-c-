Console.Clear();



void Lesson_54()
{
    /*
    Задайте двумерный массив. Напишите программу, 
    которая упорядочит по убыванию элементы каждой строки двумерного массива.
    */
    Console.WriteLine("Eenter the number of rows");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("enter the number of columns");
    int columns = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int [rows,columns];
    random_array(array,0,10);
    print_array(array);
    ordering_an_array_rows(array);
    print_array(array);
}



void Lesson_56()
{
    /*
    Задайте прямоугольный двумерный массив. 
    Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    */
    Console.WriteLine("Eenter the number of rows");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("enter the number of columns");
    int columns = Convert.ToInt32(Console.ReadLine());
    
    int [,] array = new int [rows,columns];
    random_array(array,0,10);
    print_array(array);
    summ( array);


}

void summ (int [,] array)
{
    int count = 0;
    int sum = 0;

    int [] arr_summ = new int [array.GetLength(0)];
    for (int k = 0 ; k < array.GetLength(0); k++)
    {
        for (int i = 0 ; i < array.GetLength(0); i++)
        {
            sum = 0;
            for (int j = 0 ; j < array.GetLength(1); j++)
            {
                sum += array[i,j];
            }
            arr_summ[k] = sum;
            Console.WriteLine ($"Сумма элементов строки  {k} = {sum}"); 
        } 
    }
 void min_sum (int [] arr_summ)
 {
     int min_sum = arr_summ[0]; 
     int position = 0;
    for (int i = 0 ; i < arr_summ.Length; i++ )
    {
        if (arr_summ[i] < min_sum) 
        {
            min_sum = arr_summ[i];
            position = i;
        }
    }
    Console.WriteLine ($"Строка {position} имеет минимальную суму элементов {min_sum}");
 }
}





void ordering_an_array_rows(int [,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    
    for (int i = 0 ; i < rows; i++)
    {
        for (int j = 0 ; j < columns - 1; j++)
        {
            for (int k = j + 1; k < columns ; k++)
            {
                if (array[i,j] < array[i,k]) 
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;  
                }
                
            }
        }
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


//Lesson_54();
Lesson_56();