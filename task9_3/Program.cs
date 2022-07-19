// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int m = Prompt("Введите натуральное число M: ");
int n = Prompt("Введите натуральное число N: ");
int function = A(m, n);

int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return A(m - 1, 1);
    }
    else
    {
        return A(m - 1, A(m, n - 1));
    }
    A(m, n);
}

int function1 = A(m, n);
System.Console.WriteLine($"Функция Аккермана равна: {function}");