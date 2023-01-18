//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//  Пример:
//  6 -> да
//  7 -> да
//  1 -> нет

int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string inputValue = System.Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

bool ValidateNumberWeek(int number)
{
    if (number >= 1 && number <= 7)
    {
        return true;
    }
    System.Console.WriteLine($"Число {number} не является обозначением дня недели");
    return false;
}
string[] weeks = new string [7]{"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
int number = InputInt("Введите число, обозначающее день недели");
if (ValidateNumberWeek(number))
{
    if (number >= 6)
    {
        System.Console.WriteLine($"Число {number} это {weeks[number - 1]}, значит выходной");
    }
    System.Console.WriteLine($"Число {number} это {weeks[number - 1]}, значит будни");
}