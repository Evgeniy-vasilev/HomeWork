// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int num = Prompt("Введите число: ");
int sum = 0;

while (num > 0)
{
    sum += num % 10;
    num = num / 10;
}

System.Console.WriteLine($"Сумма цифр равна: {sum}");