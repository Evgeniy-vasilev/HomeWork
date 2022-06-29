// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным(делится ли оно на два без остатка).

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num >= 0)
{
    if (num % 2 == 1)
    {
        Console.WriteLine($"{num} не является четным числом");
    }
    else
    {
        Console.WriteLine($"{num} является четным числом");
    }
}
else
{
    if (num % 2 == -1)
    {
        Console.WriteLine($"{num} не является четным числом");
    }
    else
    {
        Console.WriteLine($"{num} является четным числом");
    }
}