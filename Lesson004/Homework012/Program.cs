//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//  Пример:
//  452 -> 11
//  82 -> 10
//  9012 -> 12

int number = InputInt("Введите число");
SumDigitsNumber();

int InputInt(string message)    //вводим необходимые данные
{
    System.Console.Write(message + " > ");
    string? inputValue = System.Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

void SumDigitsNumber()     //функция суммирования цифер в числе
{   
    int index = number;     //переменная для вывода в консольную строку.
    int size = 0;           //переменная для фиксации размера числа (кол-во цифер в числе)
    int result = 0;
    int sum = 0;

    if (number <= 9)
    {
        sum = number;
    }

    while (number > 0)   //определяем размер числа
    {
        for (int i = 0; i < size; i++)  //суммируем цифры в числе
        {
            result = number % 10;
            sum += result;
            number /= 10;
        }
        size++;
    }
    System.Console.WriteLine($"Сумма цифер числа {index} равна: {sum}");
}