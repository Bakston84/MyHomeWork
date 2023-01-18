//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//  Пример:
//  5 -> 2, 4
//  8 -> 2, 4, 6, 8

System.Console.Write("Введите число > ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;

if (number >= count)
{
    System.Console.Write($"У числа {number} есть чётные числа: ");
    while (count <= number)
    {
        System.Console.Write($"({count}) ");
        count+=2;
    }
}

else
{
    System.Console.WriteLine($"У числа {number} нет чётных чисел");
}