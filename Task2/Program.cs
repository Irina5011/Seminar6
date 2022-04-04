// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int b1 = Prompt("Введите параметр b1 = > ");

int b2 = Prompt("Введите параметр b2 = > ");

int k1 = Prompt("Введите параметр k1 = > ");

int k2 = Prompt("Введите параметр k2 = > ");

int x = (b2 - b1) / (k1 - k2);

int y = k1 * x + b1;

Console.WriteLine($"Координата точки пересечения => ({x}, {y})");
