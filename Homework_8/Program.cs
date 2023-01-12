// Урок 8. Двумерные массивы. Продолжение
// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

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
//         Console.WriteLine(); //необходимо, чтобы получался массив со строками и столбцами, без этого записашется в одну строку
//     }
//     Console.WriteLine();// чтобы следующий массив не смешивался с прежним
// }

// void SortRowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int m = 0; m < array.GetLength(1) - 1; m++)

//                if (array[i, m] < array[i, m + 1])
//                 {
//                     int temp = array[i, m + 1];
//                     array[i, m + 1] = array[i,m];
//                     array[i, m] = temp;
//                 }
//         }

//     }
// }
// int[,] myArray = CreateRandom2Array();
// Show2Array(myArray);

// SortRowArray(myArray);
// Show2Array(myArray);




// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


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
//         Console.WriteLine(); //необходимо, чтобы получался массив со строками и столбцами, без этого записашется в одну строку
//     }
//     Console.WriteLine();// чтобы следующий массив не смешивался с прежним
// }


// void MinSumRow(int[,] array)
// {
//     int minRow = 0;
//     int minSumRow = 0;
//     int sumRow = 0;
//     for (int k = 0; k < array.GetLength(1); k++)
//     {
//         minRow += array[0, k];
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
//         if (sumRow < minRow)
//         {
//             minRow = sumRow;
//             minSumRow = i;
//         }
//         sumRow = 0;
//     }
//     Console.WriteLine($"{minSumRow + 1} строка");
// }


// int[,] myArray = CreateRandom2Array();
// Show2Array(myArray);

// MinSumRow(myArray);
// Show2Array(myArray);


// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

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
//         Console.WriteLine(); //необходимо, чтобы получался массив со строками и столбцами, без этого записашется в одну строку
//     }
//     Console.WriteLine();// чтобы следующий массив не смешивался с прежним
// }

// int[,] MultiplicationMatrix(int[,] firstmatrix, int[,] secondmatrix)
// {
//     if(firstmatrix.GetLength(1) == secondmatrix.GetLength(0))
//     {
//         int[,] Matrix = new int[firstmatrix.GetLength(0), secondmatrix.GetLength(1)];

//         for(int i = 0; i < Matrix.GetLength(0); i++)
//         {            
//             for(int j = 0; j < Matrix.GetLength(1); j++)
//             {
//                 for (int k = 0; k < Matrix.GetLength(1); k++)
//                 {
//                      Matrix[i,j] += firstmatrix[i, k] * secondmatrix[k, j];   
//                 }
//             }

//         }
//         Console.WriteLine("Произведение матриц: ");
//         return Matrix; 

//     }
//     else
//     { 
//         Console.WriteLine("Число столбцов первой матрицы не равно числу строк второй матрицы, поэтому первую матрицу нельзя умножить на вторую матрицу");
//         return firstmatrix;
//     }    
// }

// int[,] firstmatrix = CreateRandom2Array();
// Show2Array(firstmatrix);

// int[,] secondArray = CreateRandom2Array();
// Show2Array(secondArray);

// int[,] newmatrix = MultiplicationMatrix(firstmatrix, secondArray);

// Show2Array(newmatrix);





// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateRandom3DArray()
{
    Console.Write("Iput a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Iput a number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Iput a number of z: ");
    int z = Convert.ToInt32(Console.ReadLine());


    if (rows * colums * z > 90)
        Console.WriteLine("Невозможно создать данный массив");


    int[,,] array = new int[rows, colums, z];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            for (int k = 0; k < z; k++)
                array[i, j, k] = new Random().Next(10, 99);

    return array;


}

void Show2Array(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                // while(array[i,j,k]<90)
                // if(array[i, j, k] != array[i+1, j+1, k+1])
                Console.Write($"{array[i, j, k]} ({i} {j} {k})" + "\t");
        Console.WriteLine(); //необходимо, чтобы получался массив со строками и столбцами, без этого запишется в одну строку
    }
    Console.WriteLine();// чтобы следующий массив не смешивался с прежним
}

int[,,] myArray = CreateRandom3DArray();
Show2Array(myArray);






// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

