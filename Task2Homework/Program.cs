﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;
int min = num2;

if (num2 > num1)
{
    max = num2;
    min = num1;

    Console.Write("max = ");
    Console.Write(num2);
    Console.Write(" ");
    Console.Write("min = ");
    Console.Write(num1);
}
else
{
    Console.Write("max = ");
    Console.Write(num1);
    Console.Write(" ");
    Console.Write("min = ");
    Console.Write(num2);
}
