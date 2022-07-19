// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintNaturalElements(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        System.Console.Write($"Сумма натуральных элементов в промежутке от M до N равна: {sum}");
        return;
    }
    PrintNaturalElements(m, n - 1, sum);
}

int m = Prompt("Введите натуральное число M: ");
int n = Prompt("Введите натуральное число N: ");
PrintNaturalElements(m, n, 0);