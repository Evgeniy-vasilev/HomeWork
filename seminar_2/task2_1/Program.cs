// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int num(int min, int max)
{
    Random num = new Random();
    return num.Next(min, max + 1);
}

int a = num(100, 999);
Console.WriteLine(a);

int b = a / 10;
b = b % 10;

Console.WriteLine($"Вторая цифра числа: {b}");
