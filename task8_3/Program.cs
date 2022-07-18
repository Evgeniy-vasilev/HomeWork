// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int rows, int columns, int min, int max)
{
    int[,] answer = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answer[i, j] = rnd.Next(min, max + 1);
        }
    }
    return answer;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}

int rows = Prompt("Введите количество строк 1 матрицы: ");
int columns = Prompt("введите количество столбцов 1 матрицы и строк 2: ");
int columns1 = Prompt("введите количество столбцов 2 матрицы: ");
int[,] array = GenerateArray(rows, columns, 0, 10);
PrintArray(array);
System.Console.WriteLine();
int[,] array1 = GenerateArray(rows, columns, 0, 10);
PrintArray(array1);
int[,] resultArray = new int[rows, columns1];

void MultiplyMatrix(int[,] array, int[,] array1, int[,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array.GetLength(1); k++)
            {
                sum += array[i, k] * array1[k, j];
            }
            resultArray[i, j] = sum;
        }
    }
}

MultiplyMatrix(array, array1, resultArray);
System.Console.WriteLine();
System.Console.WriteLine("Произведение двух матриц: ");
PrintArray(resultArray);