/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

int n = 0;
Console.WriteLine("Введите число:");
n = int.Parse(Console.ReadLine());
if (n > 100) 
{
    int a = 0;
    int b = 0;
    a = n;
    while (a > 100)
    {
        b = a%10;
        a = a/10;
    }

Console.WriteLine($"{n} -> {b}");
}
else 
Console.WriteLine($"{n} ->третьей цифры нет");