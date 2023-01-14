// Урок 9. Рекурсия
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// void ShowNums(int n)
// {

//     Console.Write(n + " ");
//     if(n>1) ShowNums(n-1);
//     if(n<1) Console.WriteLine("This number dont natural");


// }
// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Натуральные числа от N до 1: ");
// ShowNums(number);




// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int SumDiff(int numA, int numB)
// {
//     if(numA>numB) return SumDiff(numA, numB+1)+numB;
//     else if(numA<numB) return SumDiff(numA+1, numB)+numA;
//     else return numA;
// }

// Console.Write("Input M: ");
// int numM = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input N: ");
// int numN = Convert.ToInt32(Console.ReadLine());
// Console.Write("Sum between number N and M: ");


// System.Console.WriteLine(SumDiff(numM, numN));


// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

ulong Akkerman(ulong m, ulong n)
{
    if(m == 0)
        return n + 1;
    else if(n == 0 && m>0) return Akkerman(m - 1 , 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));

}

Console.Write("Input num M ");
ulong num1 = Convert.ToUInt64(Console.ReadLine());

Console.Write("Input num N ");
ulong num2 = Convert.ToUInt64(Console.ReadLine());

Console.WriteLine(Akkerman(num1, num2));


