// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Пример:
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int InputInt(string position)
{
    System.Console.Write($"{position} > ");
    return Convert.ToInt32(Console.ReadLine());
}

void CreateArray(double[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 10) + rnd.NextDouble();
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]:F2} ");
        }
        System.Console.WriteLine();
    }
}

int rows = InputInt($"Введите количество строк массива");
int col = InputInt($"Введите количество столбцов массива");
double[,] array = new double[rows, col];
CreateArray(array);
PrintArray(array);