// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num(int min, int max)
{
    Random num = new Random();
    return num.Next(min, max + 1);
}

int a = num(100, 999);
Console.WriteLine(a);

int num1 = a / 100;
int num2 = a % 10;
int result = num1 * 10 + num2;

Console.WriteLine($"Результат: {result} ");

