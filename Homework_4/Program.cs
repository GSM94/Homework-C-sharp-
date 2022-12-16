// Урок 4. Функции

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    

    for(int i = 0; i < size; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Iput a number of elements: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Iput a number of elements: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Iput a number of elements: ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Iput a number of elements: ");
        int d = Convert.ToInt32(Console.ReadLine());

    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        // Console.WriteLine($"array[{i+1}] is {array[i]}");
        Console.Write(array[i] + " ");
}

int size = 4;


int[] myArray = CreateRandomArray(size);
ShowArray(myArray);

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


// Console.WriteLine("Input number A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int sum = a;

// for (int i = 1; b > i; i++)
// {
// sum = sum * a;
// }
// Console.WriteLine($"A в степени B равно:  {sum}");

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int len = NumberLen(number);
// SumNumbers(number, len);

// int NumberLen(int a)
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         index++;
//     }
//     return index;
// }


// void SumNumbers(int number, int len)
// {
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += number % 10;
//         number /= 10;
//     }
//     Console.WriteLine($"Сумма цифр: {sum}");
// }




// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next();
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         // Console.WriteLine($"array[{i+1}] is {array[i]}");
//         Console.Write(array[i] + " ");
// }
// Console.Write("Iput a number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Iput a min possible value: ");

// int[] myArray = CreateRandomArray(size);
// ShowArray(myArray);

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

