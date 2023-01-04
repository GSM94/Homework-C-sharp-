//Домашняя работа № 7

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] CreateRandom2Array()
// {
//     Console.Write("Iput a number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Iput a number of colums: ");
//     int colums = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Iput a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Iput a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine();
//     double[,] array = new double[rows, colums];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < colums; j++)
//             array[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(minValue, maxValue), 1);
//     return array;
// }

// void Show2Array(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + "\t");
//         Console.WriteLine(); //необходимо, чтобы получался массив со строками и столбцами, без этого записашется в одну строку
//     }
//     Console.WriteLine();// чтобы следующий массив не смешивался с прежним
// }



// double[,] myArray = CreateRandom2Array();
// Show2Array(myArray);



// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] CreateRandom2Array()
// {
//     Console.Write("Iput a number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Iput a number of colums: ");
//     int colums = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Iput a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Iput a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < colums; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

// void Show2Array(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + "\t");
//         Console.WriteLine(); //необходимо, чтобы получался массив со строками и столбцами, без этого запишется в одну строку
//     }
//     Console.WriteLine();// чтобы следующий массив не смешивался с прежним
// }

// void FindIndexnumber(int[,] array)
// {
//     Console.Write("Input index 1: ");
//     int indexRows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input index 1: ");
//     int indexColums = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine();// чтобы следующий массив не смешивался с прежним
//     if(array.GetLength(0)<=indexRows || array.GetLength(1) <= indexColums) Console.WriteLine("Element not found");
//     else Console.WriteLine($"Index rows: {indexRows} Index colums: {indexColums} This element = {array[indexRows, indexColums]} ");
// }


// int[,] myArray = CreateRandom2Array();
// Show2Array(myArray);
// FindIndexnumber(myArray);


// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> числа с такими индексами в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2Array()
{
    Console.Write("Iput a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Iput a number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Iput a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Iput a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine(); //необходимо, чтобы получался массив со строками и столбцами, без этого записашется в одну строку
    }
    Console.WriteLine();// чтобы следующий массив не смешивался с прежним
}

double[] middleColums(int[,] array)
{
    double[] middleArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            middleArray[j] += array[i, j];
            middleArray[j] /= array.GetLength(0);
        
    }
    return middleArray;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(string.Format("{0:0.00}",array[i]) + "\t");
    }
    Console.WriteLine();
}



int[,] myArray = CreateRandom2Array();
Show2Array(myArray);


double[] resultAray = middleColums(myArray);
ShowArray(resultAray);


// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


