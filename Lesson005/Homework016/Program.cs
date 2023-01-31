//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//  Пример:
//  [3 7 22 2 78] -> 76

int max = 99;
int min = -99;
double maxNumber = 0;
double minNumber = 0;
double[] array = CreatArray();
PrintArray(array);
PrintArrayFunctions(array);

double[] CreatArray()
{
    double[] array = new double[5];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max) + rnd.NextDouble();
    }
    return array;
}

double MaxNumber(double maxNumber)
{
    bool trigger = true;
    foreach (double item in array)
    {
        if (trigger)
        {
            maxNumber = item;
            trigger = false;
        }
        else
        {
            if (maxNumber < item)
                maxNumber = item;
        }
    }
    return maxNumber;
}

double MinNumber(double minNumber)
{
    bool trigger = true;
    foreach (double item in array)
    {
        if (trigger)
        {
            minNumber = item;
            trigger = false;
        }
        else
        {
            if (minNumber > item)
                minNumber = item;
        }
    }
    return minNumber;
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

void PrintArrayFunctions(double[] array)    //выводим результат массива
{
    System.Console.Write("В массиве [");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]:F2}");
        if (i != array.Length - 1)
            System.Console.Write(", ");
    }
    double printMax = MaxNumber(maxNumber);
    double printMin = MinNumber(minNumber);
    double result = printMax - printMin;
    System.Console.WriteLine($"] разница между максимальным {printMax:F2} и минимальным {printMin:F2} элементов, равна: {result:F2}");
}