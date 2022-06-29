// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int num = Prompt("Введите трехзначное число: ");

if (num > 99 && num <1000)
{
    int b = num / 10;
    b = b % 10;
    Console.WriteLine($"Вторая цифра числа: {b}");
}
else
{
    Console.WriteLine("Введено неверное число");
}
            