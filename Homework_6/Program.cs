                                            // Домашняя работа №6
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.WriteLine("Input five numbers!");

// Console.Write("Iput a num1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Iput a num2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Iput a num3: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Iput a num4: ");
// int num4 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Iput a num5: ");
// int num5 = Convert.ToInt32(Console.ReadLine());

// int count = 0;
// if(num1 > 0) count++;
// if(num2 > 0) count++;
// if(num3 > 0) count++;
// if(num4 > 0) count++;
// if(num5 > 0) count++;


// Console.Write("Положительных чисел - " + count + ".");

// 2 вариант (не работает!) для бесконечного ввода без массива

// int ShowArr(int number)
// {
//     int num = 1;
//     // string strnumber = number.ToString();
//     // string stoping = "stop"; 
//     // int intstoping = int.Parse(stoping);
//     int count = 0;
//     while(num != 0)
//     {
//         Console.Write("Введите число: ");
        // Console.Write("Если хотите прекратить ввод данных - наберите 0.");
//         int usernum = Convert.ToInt32(Console.ReadLine());
//         if(num==0)
//             break;
//         count++;
//         if(num>0)
//         count++;    
//     }
//     return count;
    
// }

// // Console.Write("Введите числ: ");
// // int usernum = Convert.ToInt32(Console.ReadLine());

// int result = ShowArr(usernum);
// Console.Write("Положительных чисел - " + result);
// // ShowArr(usernum);





// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

if(k1==k2) Console.WriteLine("Прямые параллельны и они не пересекутся.");
else    Console.WriteLine($"Две прямые пересекутся в точке в точке [{x}, {y}]");




// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)