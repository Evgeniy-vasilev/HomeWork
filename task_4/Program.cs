// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите положительное число большее 1: ");
int num = int.Parse(Console.ReadLine());
int count = 2;

if (num > 1)
{
    while (count <= num)
    {
        Console.Write(count + " ");
        count = count + 2;
    }
}
else
{
    Console.WriteLine("Введено не верное значение!");
}

