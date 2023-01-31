//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//  Пример:
//  [3 7 22 2 78] -> 76

double[] array = CreatArray();
PrintArray(array);

double[] CreatArray()
{
    double[] array = new double[5];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-99, 99)+rnd.NextDouble();
    }
    return array;
}

void PrintArray(double[] array)    //выводим результат массива
{
    System.Console.Write("В массиве [");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]:F2}");
        if (i != array.Length - 1)
            System.Console.Write(", ");
    }
    double min = array.Min();
    double max = array.Max();
    double result = max - min;
    System.Console.WriteLine($"] разница между максимальным {max:F2} и минимальным {min:F2} элементов, равна: {result:F2}");
}