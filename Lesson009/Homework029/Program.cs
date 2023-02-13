// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// Пример:
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputInt(string number)
{
    System.Console.Write($"{number} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int AckermannFunction(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
    return AckermannFunction(numberM, numberN);
}

int numberM = InputInt($"Введите число:");
int numberN = InputInt($"Введите аргумент:");
int result = AckermannFunction(numberM, numberN);
Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {result}");