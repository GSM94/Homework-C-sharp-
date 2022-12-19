                                    //Домашняя работа №5
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(100, 1000);
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         // Console.WriteLine($"array[{i+1}] is {array[i]}");
//         Console.Write(array[i] + " ");
// }

// int pozitivNumber(int[]array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0)
//             count++;
        
//     }
//     return count;
// }

// Console.Write("Iput a number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());


// int[] myArray = CreateRandomArray(size);
// ShowArray(myArray);

// int result = pozitivNumber(myArray);
// Console.WriteLine(result);


// [345, 897, 568, 234] -> 2

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(1, 10);
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         // Console.WriteLine($"array[{i+1}] is {array[i]}");
//         Console.Write(array[i] + " ");
        
// }

// int sumNegativespozicion(int[] array)
// {
//     int sum = 0;
    
//         for(int i = 1; i <array.Length; i+=2) // здесь счет по индексу. Если счет по позиции, то i=0
//             sum = sum + array[i];
            
//     return sum;
// }

// Console.Write("Iput a number of elements: ");

// int size = Convert.ToInt32(Console.ReadLine());


// int[] myArray = CreateRandomArray(size);
// ShowArray(myArray);

// int result = sumNegativespozicion(myArray);
// Console.WriteLine();
// Console.Write("Ответ: " + result);

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.



// [3 7 22 2 78] -> 76

double[] CreateRandomArray(int size)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().NextDouble() + new Random().Next(1, 10);
    return array;
}
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        // Console.WriteLine($"array[{i+1}] is {array[i]}");
        Console.Write(array[i] + " ");
        
}

double minArray(double[] array)
{
    double min = array[0];
   
    for(int i = 0; i < array.Length; i++)
    if(array[i] < min) 
        min = array[i];
    return min;
}

double maxArray(double[] array)
{
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
        if(array[i] > array[0]) 
            max = array[i]; 
    return max;
}
Console.Write("Iput a number of elements: ");

int size = Convert.ToInt32(Console.ReadLine());


double[] myArray = CreateRandomArray(size);
ShowArray(myArray);

double minresult = minArray(myArray);
double maxresult = maxArray(myArray);
Console.WriteLine();
Console.WriteLine("Massiv of "  + size + " elements");
Console.WriteLine("Maximum number: "  + maxresult);
Console.WriteLine("Manimum number: "  + minresult);
Console.WriteLine("Deference between maximum and minimum numbers: "  + (maxresult - minresult));





