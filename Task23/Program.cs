﻿/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

void Function(int a) 
{
    if (a > 5 && a < 8) 
        {
            Console.WriteLine($"{a} -> да"); 
        }
    else
        {
            Console.WriteLine($"{a} -> нет"); 
        }
}

Console.WriteLine($"Введите число:");
int a = 0;
a = int.Parse(Console.ReadLine());

Function(a);