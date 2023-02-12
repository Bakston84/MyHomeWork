// Напишите программу, которая заполнит спирально квадратный массив.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void CreateSpiralArray(int[,] array)
{
    int x = array.GetLength(1);
    int y = array.GetLength(0);
    int number = 0;
    for (int index = 0; index < y; index++)
    {

        for (int i = index; i < y - index; i++) //вправо
        {
            array[index, i] = number;
            number++;
        }
        for (int j = index + 1; j < x - index; j++) //вниз
        {
            array[j, y - index - 1] = number;
            number++;
        }
        for (int i = y - index - 2; i >= index; i--) //влево
        {
            array[x - index - 1, i] = number;
            number++;
        }
        for (int j = x - index - 2; j > index; j--) //вверх
        {
            array[j, index] = number;
            number++;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] array = new int[7, 7];
CreateSpiralArray(array);
PrintArray(array);