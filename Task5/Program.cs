﻿// Задача 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"


Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = -a;

for (b = -a; b <= a; b++)
{
    Console.Write(b);
    if (b < a)
    {
        Console.Write(", ");
    }
}

// do
// {
//     Console.WriteLine(b);
//     if (b < a)
//     {
//         Console.Write(", ");
//     }
//     b++;
// }
// while (b <= a);