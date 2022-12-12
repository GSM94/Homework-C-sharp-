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