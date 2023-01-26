//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//  Пример:
//  452 -> 11
//  82 -> 10
//  9012 -> 12

int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = System.Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int SumDigitsNumber(int number)
{
    if (number <= 9)
        return number;
    int index = number;
    int size = 0;
    int result = 0;
    int sum = 0;
    while (index > 0)   //определяем размер числа
    {
        index = index / 10;
        for (int i = 0; i < size; i++)  //суммируем цифры в числе
        {
            result = number % 10;
            sum += result;
            number /= 10;
        }
        size++;
    }
    return sum;
}

int number = InputInt("Введите число");
System.Console.WriteLine($"Сумма цифер числа {number} = {SumDigitsNumber(number)}");