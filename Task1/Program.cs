// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

int number = Prompt("Сколько чисел необходимо проверить? Введите количество =>");
Console.WriteLine();

int count = 0;

for (int i = 0; i< number; i++)
{
    Console.Write($"Введите число {i+1}: ");
    int number2 = int.Parse(Console.ReadLine());
    if(number2>0)
    count++;
}
Console.Write($"Больше нуля => {count}");

