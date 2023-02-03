// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Пример:
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int InputInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int CheckPositivity(int result)
{
    for (int i = 1; i < 6; i++)
    {
        int number = InputInt($"Введите {i} число");
        if (number > 0)
        result++;
    }
    return result;
}

int result = 0;
System.Console.WriteLine($"Чисел больше 0: {CheckPositivity(result)}");