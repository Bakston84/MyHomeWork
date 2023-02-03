//  Найти в массиве второй максимум и минимум.
//  Пример:
//  [3 7 22 2 78] -> второй максимум 22, второй минимум 3

int[] CreateArray()      //создаём массив генератором случайных чисел
{
    int[] array = new int[8];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-99, 99);
    }
    return array;
}

int SecondMax(int[] array)    //находим второй максимум
{
    int secondMax = array[0];
    int firstMax = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > firstMax)
        {
            secondMax = firstMax;
            firstMax = array[i];
        }
        else if (array[i] > secondMax && array[i] < firstMax)
        secondMax = array[i];
    }
    return secondMax;
}

int SecondMin(int[] array)    //находим второй максимум
{
    int secondMin = array[0];
    int firstMin = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < firstMin)
        {
            secondMin = firstMin;
            firstMin = array[i];
        }
        else if (array[i] < secondMin && array[i] > firstMin)
        secondMin = array[i];
    }
    return secondMin;
}

void PrintArray(int[] array)    //выводим результат массива
{
    System.Console.Write("В массиве [");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i != array.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write($"]");
}

int[] array = CreateArray();
PrintArray(array);
System.Console.Write($" второй максимум равен: {SecondMax(array)},");
System.Console.Write($" а второй минимум равен: {SecondMin(array)}");