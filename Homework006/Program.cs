//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//  Пример:
//  645 -> 5
//  78 -> третьей цифры нет
//  32679 -> 6

int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string inputValue = System.Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

bool ValidateNumberRank3(int number)
{
    if (number >= 100)
    {
        return true;
    }
    System.Console.WriteLine($"Число {number} не является 3-хзначным и более числом");
    return false;
}

int number = InputInt("Введите 3-хзначное и более число");
if (ValidateNumberRank3(number))
{
    int numberRank3 = number;
    while (numberRank3 >= 1000)
    {
        numberRank3 = numberRank3 / 10;
    }
    int result = numberRank3 % 10;
    System.Console.WriteLine($"Вторая цифра числа {number} равна ({result})");
}