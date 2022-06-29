// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int N = Prompt("Введите число: ");
int count = 1;

while (count <= N)
{
    Console.Write(Math.Pow(count, 3) + " ");
    count++;
}

