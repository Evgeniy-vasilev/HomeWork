// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели от 1 до 7:");
int day = int.Parse(Console.ReadLine());

if (day < 1 || day > 7)
{
    Console.WriteLine("Введена не корректная цифра");
}
else
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Выходной день");
    }
    else
    {
        Console.WriteLine("Будний день");
    }
}