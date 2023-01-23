//  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не используйте строки
//  Пример:
//  14212 -> нет
//  12821 -> да
//  23432 -> да

string InputString(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = System.Console.ReadLine();
    return inputValue;
}

bool ValidateNumber(string number)
{
    int rank = number.Length;
    if (rank == 5)
    {
        return true;
    }
    Console.WriteLine($"Число {number} не является пятизначным");
    return false;
}

string number = InputString("Введите пятизначное число");
if (ValidateNumber(number))
{
    char[] revNumber = number.ToCharArray();
    Array.Reverse(revNumber);
    string finalNumber = new String(revNumber);
    if (number == finalNumber)
    {
        System.Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"Число {number} не является палиндромом");
    }
}