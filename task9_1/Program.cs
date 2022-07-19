// Задайте значения M и N. Напишите программу, которая выведет 
// все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintEvenNumbers(int n, int m)
{
    if (n < m)
    {
        return;
    }
    else if (n % 2 == 0)
    {
        PrintEvenNumbers(n - 2, m);
        System.Console.Write(n + " ");
    }
    else
    {
        PrintEvenNumbers(n - 1, m);
    }
}

int m = Prompt("Введите натуральное число M: ");
int n = Prompt("Введите натуральное число N: ");
PrintEvenNumbers(n, m);
