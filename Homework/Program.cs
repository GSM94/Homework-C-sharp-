                                        //Домашняя работа №1

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1>num2)
//     Console.WriteLine($"Max number is num1 = {num1}");
// else
//     Console.WriteLine($"Max number is num2 = {num2}");

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if(num1>num2 && num2>num3)
// {
//     Console.WriteLine($"Max number is num1 = {num1}");
// }
// if(num2>num1 && num2>num3)
// {
//     Console.WriteLine($"Max number is num2 = {num2}");
// }
// else
// {
//     Console.WriteLine($"Max number is num3 = {num3}");
// }

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num % 2 == 0)
// {
//     Console.WriteLine("Yes, its an even number!");
// }
// else
// {
//     Console.WriteLine("No, its not an even number");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.Write("Input an integer number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int current = 1;

// while(current <= num)
// {
//     if(current % 2 == 0)
//     {
//         Console.Write(current + " ");
//     }
//     current ++;
// }

                                           
                                           
                                           
                                            
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
                                        // Домашняя работа №3

// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 9999 & number < 100000)
// {
//     int number1 = number / 10000;
//     int number2 = (number / 1000) % 10;
//     int number4 = (number / 10) % 10;
//     int number5 = number  % 10;

//     if (number1 ==  number5 && number2 == number4)
//     {
//         Console.WriteLine($"{number} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - НЕ палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
// }

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double Distance(double xa, double ya, double za, double xb, double yb, double zb)
// {
//     // double x = xb - xa;
//     // double y = yb - ya;
//     // double z = zb - za;
//     double result = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
//     return result;
// }

// Console.Write("Input xA: ");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input yA: ");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input zA: ");
// double za = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input xB: ");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input yB: ");
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.Write("Inputy zB: ");
// double zb = Convert.ToDouble(Console.ReadLine());

// double Distanceresult = Distance(xa, ya, za, xb, yb, zb);

// Console.WriteLine("Расстояние между точками: " + Distanceresult);

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void Squares(int number)
// {
//     int counter = 1;
//     while(counter <= number)
//     {
//         Console.Write($"{Math.Pow(counter, 3)}");
//         if(counter != number) Console.Write(", "); 
//         counter++;
//     }
// }
// Console.Write("Введите число: ");
// int usernum = Convert.ToInt32(Console.ReadLine());

// Console.Write("Серия квадратов:");
// Squares(usernum);

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125