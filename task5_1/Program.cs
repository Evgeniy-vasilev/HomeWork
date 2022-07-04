// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int Length = 10, int min = 100, int max = 999)
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
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    int j = array[i] % 2;
    if (j == 0)
    {
        count++;
    }
}
PrintArray(array);
System.Console.WriteLine($"Количество четных чисел в массиве равно: {count}");
