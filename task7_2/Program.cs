// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

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

int rows = Prompt("Введите количество строк: ");
int columns = Prompt("введите количество столбцов: ");
int[,] myArray = GenerateArray(rows, columns, -10, 10);
PrintArray(myArray);

int row = Prompt("Введите номер строки: ");
int column = Prompt("Введите номер столбца: ");

void FindValue(int[,] array, int row, int column)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (row > rows || column > columns)
            {
                System.Console.WriteLine("Такого числа в массиве нет");
            }
            else
            {
                System.Console.WriteLine($"Значение элемента на позиции ({row}, {column}) равно: {array[row - 1, column - 1]}");             
            }
            return;
        }
    }
}

FindValue(myArray, row, column);
