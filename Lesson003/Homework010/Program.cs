//  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//  Пример:
//  3 -> 1, 8, 27
//  5 -> 1, 8, 27, 64, 125

int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = System.Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int number = InputInt("Введите число");
System.Console.Write($"Таблица кубов числа ({number}): ");
for (int i = 1; i < number + 1; i++)
{
    double cubNumber = Math.Pow(i, 3);
    if (number == i)
    {
        System.Console.Write($"{cubNumber}");
    }
    else
    {
        System.Console.Write($"{cubNumber}, ");
    }
}