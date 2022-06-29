// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число А: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA == numberB)
{
    Console.WriteLine($"Числа равны");
}

else
{
    if (numberA > numberB)
    {
        Console.WriteLine($"Большее число: {numberA}, меньшее число: {numberB} ");
    }
    else
    {
        Console.WriteLine($"Большее число: {numberB}, меньшее число: {numberA} ");
    }
}