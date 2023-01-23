//  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не используйте строки
//  Пример:
//  14212 -> нет
//  12821 -> да
//  23432 -> да

int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = System.Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

bool ValidateNumber(int number)
{
    if (number >= 10000 && number <= 99999)
    {
        return true;
    }
    Console.WriteLine($"Число {number} не является пятизначным");
    return false;
}

int ReversNumber(int number)
{
    int reversed = 0;
    while (number > 0)
    {
        reversed = reversed * 10 + number % 10;
        number /= 10;
    }
    return reversed;
}

int number = InputInt("Введите пятизначное число");
if (ValidateNumber(number))
{
    if (number == ReversNumber(number))
    {
        System.Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"Число {number} не является палиндромом");
    }
}