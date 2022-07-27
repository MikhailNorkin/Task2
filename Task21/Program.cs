Console.WriteLine($"Введите число: ");
int n = 0;
int k = 0;
n = int.Parse(Console.ReadLine());
k = n / 10;
Console.WriteLine($"{k%10}");
