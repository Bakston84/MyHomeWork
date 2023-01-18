//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//  Пример:
//  456 -> 5
//  782 -> 8
//  918 -> 1

int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string inputValue = System.Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

bool ValidateNumberRank2(int number)
{
    if (number > 99 && number < 1000)
    {
        return true;
    }
    System.Console.WriteLine($"Число {number} не является 3-хзначным числом");
    return false;
}

int number = InputInt("Введите 3-хзначное число");
if (ValidateNumberRank2(number))
{
    int result = number / 10 % 10;
    System.Console.WriteLine($"Вторая цифра числа {number} равна ({result})");
}