﻿Console.Write("Введите число a: ");
int a =  int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b =  int.Parse(Console.ReadLine());
Console.Write("Введите число c: ");
int c =  int.Parse(Console.ReadLine());
int max = a;
Console.Write("Максимальное число: ");
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine(max);