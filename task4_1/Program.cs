// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exp(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}

System.Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
System.Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
int exp = Exp(A, B);
System.Console.WriteLine($"Результат: {exp}");