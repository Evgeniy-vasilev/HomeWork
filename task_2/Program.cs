// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Введите число C: ");
int numberC = int.Parse(Console.ReadLine());
int max = 0;

if (numberA >= numberB)
{
    max = numberA;
}
else
{
    max = numberB;
}
if (max >= numberC)
{
    Console.WriteLine($"Максимальное число: {max}");
}
else
{
    Console.WriteLine($"Максимальное число: {numberC}");
}
