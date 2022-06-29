// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int num = Prompt("Введите пятизначное число: ");
int inv = 0;
int num1 = num;

while (num1 > 0)
{
    inv = inv * 10 + num1 % 10;
    num1 = num1 / 10;
}
if (num < 10000 || num > 99999)
{
    System.Console.WriteLine("Введено неверное число");
}
else if (num == inv)
{
    System.Console.WriteLine($"Число {num} является полиндромом");
}
else
{
    System.Console.WriteLine($"Число {num} не является полиндромом");
}