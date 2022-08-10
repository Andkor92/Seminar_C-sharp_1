// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if (num2 > num1 & num2 > num3)
{
    max = num2;

    Console.Write("max = ");
    Console.Write(num2);
}
else if (num3 > num1 & num3 > num2)
{
    max = num3;

    Console.Write("max = ");
    Console.Write(num3);
}
else
{
    Console.Write("max = ");
    Console.Write(num1);
}


// Console.WriteLine("Введите числа через пробел: "); //Для большего количества значений
// int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
// int i = 0;
// int max = array [0]; //После семинара присвоил max не 0, а значение массива под нулевым индексом. Перепроверил - ВРОДЕ ВСЕ ИСПРАВНО РАБОТАЕТ :)

// while (i < array.Length)
// {
//     if (array [i] > max)
//     {
//         max = array [i];
//         i++;
//     }
//     i++;
// }

// Console.Write("max = ");
// Console.Write(max);
