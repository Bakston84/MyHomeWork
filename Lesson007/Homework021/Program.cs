// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет

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
            array[i, j] = rnd.Next(-10, 10) + rnd.NextDouble(); ;
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

void InputPosition(double[,] array)
{
    int positionX = InputInt("Введите номер строки массива");
    int positionY = InputInt("Введите номер столбца массива");
    if (positionX > array.GetLength(0) || positionY > array.GetLength(1))
    {
        System.Console.WriteLine($"Такой позиции массива ({positionX};{positionY}) не существует. Попробуйте ввести другие параметры");
        InputPosition(array);
    }
    else SearchPosition(array, positionX, positionY);
}

void SearchPosition(double[,] array, int positionX, int positionY)
{
    double result = 0;
    for (int i = 0; i < positionX; i++)
    {
        for (int j = 0; j < positionY; j++)
        {
            result = array[i, j];
        }
    }
    System.Console.WriteLine($"Элемент в позиции массива ({positionX};{positionY}), равен: {result:F2}");
}

double[,] array = new double[3, 4];
CreateArray(array);
PrintArray(array);
InputPosition(array);