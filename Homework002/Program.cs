//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//  Пример:
//  2, 3, 7 -> 7
//  44 5 78 -> 78
//  22 3 9 -> 22

int Max(int firstNumber, int secondNumber, int thirdNumber)
{
    int result = firstNumber;
    if (secondNumber > result) result = secondNumber;
    if (thirdNumber > result) result = thirdNumber;
    return result;
}

System.Console.Write("Введите первое число > ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число > ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число > ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = Max(firstNumber, secondNumber, thirdNumber);

System.Console.WriteLine($"Максимальное число из трёх: {max}");