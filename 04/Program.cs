﻿// 4. Напишите программу, которая на вход принимает одно число
// (N), а на выходе показывает все целые числа в промежутке от -N
// до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

string s_a = Console.ReadLine();
int a = int.Parse(s_a);
int result = a * (-1);

while (result <= a)
{
    Console.Write(result);
    if (result < a)
        Console.Write(", ");
    result++;
}