//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//  Пример:
//  a = 5; b = 7 -> max = 7
//  a = 2 b = 10 -> max = 10
//  a = -9 b = -3 -> max = -3

System.Console.Write("Введите первое число > ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число > ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    System.Console.WriteLine($"Первое число ({firstNumber}), больше второго числа ({secondNumber})");
}
else
{
    System.Console.WriteLine($"Второе число ({secondNumber}) больше первого числа ({firstNumber})");
}