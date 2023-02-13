// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// Пример:
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputInt(string number)
{
    System.Console.Write($"{number} > ");
    return Convert.ToInt32(Console.ReadLine());
}

void SumNumbers(int m, int n, int result)
{
    if (m == n)
    {
        PrintResult(result);
        return;
    }
    m++;
    result = result + m;
    SumNumbers(m, n, result);
}

void PrintResult(int m)
{
    System.Console.Write($"({m}) ");
}

int numberM = InputInt("Введите первое число");
int numberN = InputInt("Введите второе число");
int result = numberM;
System.Console.Write($"Сумма натуральных чисел: ");
SumNumbers(numberM, numberN, result);