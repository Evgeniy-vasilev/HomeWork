// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 67] -> 0

int[] GenerateArray(int Length = 8, int min = 0, int max = 10)
{
    int[] newArray = new int[Length];
    Random rnd = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(min, max + 1);
    }
    return newArray;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write(", " + array[i]);
    }
    System.Console.WriteLine("]");
}

int[] array = GenerateArray();
int sum = 0;
for (int i = 0; i < array.Length; i += 2)
{
    sum += array[i];
}

PrintArray(array);
System.Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях, равна: {sum}");