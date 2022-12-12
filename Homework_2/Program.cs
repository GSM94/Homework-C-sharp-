// Домашняя работа № 2

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int CutNumber(int num)
// {
//     int ed = num % 100;
//     int result = ed / 10;
//     return result;
// }

// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int newNum = CutNumber(num);

// if(num > 99 && num < 1000)
// Console.WriteLine($"New version of number {num} is {newNum}");
// else
// {  
//     Console.Write("Данное число не трехзначное! Повторите попытку, перезапустив прогамму.");
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет (-1).

//  int Third(int number)
// {
//     int result = -1;
//     if (number >= 100)
//     {
//         while (number > 999)
//         {
//             number = number / 10;
//         }
//         result = number % 10;
//     }
//     return result;
             
// }

// Console.Write("Input an integer number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int newnum =Third(num);
// Console.Write($"Its an integer number - {num} and third element this number -  {newnum}");


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.WriteLine("Введите номер дня недели");
// int number = Convert.ToInt32(Console.ReadLine());

// void week(int number)
// {
//         if(number >= 1 && number <= 5)
//     {
//         Console.WriteLine("Это рабочий день недели");  
//     }
//     else if(number >=6 && number <= 7)
//     {
//          Console.WriteLine("Этот день недели выходной");
//     }
//     else
//     {
//         Console.WriteLine("Такого дня недели не существует");
//     }
// }
// week(number);