// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

System.Console.Write("Введите количество чисел: ");
int M = int.Parse(Console.ReadLine());
int[] array = new int[M];

void Numbers(int M)
{
    for (int i = 0; i < M; i++)
    {
    System.Console.Write($"Введите {i + 1} число: ");
    array[i] = int.Parse(Console.ReadLine());
    }
}

int Counter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Numbers(M);
System.Console.WriteLine($"Количество чисел больше 0 равно: {Counter(array)}");