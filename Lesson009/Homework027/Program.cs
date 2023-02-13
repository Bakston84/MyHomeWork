// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа 
// в промежутке от M до N с помощью рекурсии.
// Пример:
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int InputInt(string number)
{
    System.Console.Write($"{number} > ");
    return Convert.ToInt32(Console.ReadLine());
}

void SearchPrivateNumbers(int m, int n)
{
    if (m > n) return;
    if (m % 2 == 0) PrintResult(m);
    m++;
    SearchPrivateNumbers(m, n);
}

void PrintResult (int m)
{
    System.Console.Write($"({m}) ");
}

int numberM = InputInt("Введите первое число");
int numberN = InputInt("Введите второе число");
System.Console.Write($"Чётные натуральные числа: ");
SearchPrivateNumbers(numberM, numberN);