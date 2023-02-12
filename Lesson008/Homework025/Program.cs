// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
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

int[,] MultiplicationTwoMatrix(int[,] firstArray, int[,] secondArray)
{
    int[,] resultArray = new int[firstArray.GetLongLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
            }
            resultArray[i, j] = resultArray[i, j];
        }
    }
    return resultArray;
}
int[,] array = new int[4, 4];
int[,] firstArray = CreateArray(array);
int[,] secondArray = CreateArray(array);
int[,] resultArray = MultiplicationTwoMatrix(firstArray, secondArray);
System.Console.WriteLine("Первый массив:");
PrintArray(firstArray);
System.Console.WriteLine("Второй массив:");
PrintArray(secondArray);
System.Console.WriteLine("Произведение первого и второго массива:");
PrintArray(resultArray);

