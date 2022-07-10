// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

double b1 = Prompt("Введите b1: ");
double k1 = Prompt("Введите k1: ");
double b2 = Prompt("Введите b2: ");
double k2 = Prompt("Введите k2: ");

if (k1 == k2)
{
    System.Console.WriteLine("Прямые не пересекаются");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    System.Console.WriteLine($"Точка пересечения двух прямых: ({x}, {y})");
}

