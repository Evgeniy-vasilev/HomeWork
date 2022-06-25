//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int num = Prompt("Введите число: ");

if (num < 100)
{
    Console.WriteLine("В этом числе третьей цифры нет");
}
else
{
    while (num > 1000)
    {
        num = num / 10;
    }
    int A = num % 10;
    Console.WriteLine($"Третья цифра: {A}");
}
