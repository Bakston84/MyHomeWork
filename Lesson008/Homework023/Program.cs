// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) //прогонка по строке
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++) //позиция столбца
        {
            for (int k = array.GetLength(1) - 1; k > j; k--) //переборка столбца на минимум
            {
                if (array[i, k] > array[i, k - 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k - 1];
                    array[i, k - 1] = temp;
                }
            }
        }
    }
    return;
}

int[,] array = new int[4, 4];
CreateArray(array);
PrintArray(array);
SortDescending(array);
PrintArray(array);