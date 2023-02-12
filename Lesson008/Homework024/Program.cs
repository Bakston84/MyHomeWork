// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void CreateArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int ResultSummArray(int[,] array, int result)
{
    int[] tempArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++) //строка
    {
        for (int j = 0; j < array.GetLength(1); j++) //столбец
        {
            result = result + array[i, j];
            tempArray[i] = result;
        }
        result = 0;
    }
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        if (tempArray[i] == tempArray.Min())
            result = i + 1;
    }
    return result;
}

int[,] array = new int[4, 4];
int result = 0;
CreateArray(array);
PrintArray(array);
result = ResultSummArray(array, result);
System.Console.WriteLine($"{result} строка с наименьшей суммой элиментов.");