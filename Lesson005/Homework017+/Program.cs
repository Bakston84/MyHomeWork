//  Задайте найти в массиве второй максимум и минимум.
//  Пример:
//  [3 7 22 2 78] -> второй максимум 22, второй минимум 3

int min = -99;
int max = 99;
int[] array = CreatArray(12);
PrintArray(array);

int[] CreatArray(int size)      //создаём массив генератором случайных чисел
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

int SecondMax(int secondMax)    //находим второй максимум
{
    int firstMaxArray = array.Max();
    secondMax = 0;
    int[] secondArray = new int[array.Length];
    for (int i = 0; i < secondArray.Length; i++)
    {
        if (array[i] == firstMaxArray)
        {
            secondArray[i] = min;
        }
        else
        {
            secondArray[i] = array[i];
        }
    }
    secondMax = secondArray.Max();
    return secondMax;
}

int SecondMin(int secondMin)    //находим второй минимум
{
    int firstMinArray = array.Min();
    secondMin = 0;
    int[] secondArray = new int[array.Length];
    for (int i = 0; i < secondArray.Length; i++)
    {
        if (array[i] == firstMinArray)
        {
            secondArray[i] = max;
        }
        else
        {
            secondArray[i] = array[i];
        }
    }
    secondMin = secondArray.Min();
    return secondMin;
}

void PrintArray(int[] array)    //выводим результат массива
{
    int secondMax = 0;
    int secondMin = 0;
    System.Console.Write("В массиве [");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i != array.Length - 1)
            System.Console.Write(", ");
    }
    secondMax = SecondMax(secondMax);
    secondMin = SecondMin(secondMin);
    System.Console.WriteLine($"] второй максимум равен: {secondMax}, а второй минимум равен: {secondMin}");
}