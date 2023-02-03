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

int FirstMax(int[] array, int firstMax)
{
    bool trigger = true;
    foreach (int item in array)
    {
        if (trigger)
        {
            firstMax = item;
            trigger = false;
        }
        else
        {
            if (firstMax < item)
                firstMax = item;
        }
    }
    return firstMax;
}

int FirstMin(int[] array, int firstMin)
{
    bool trigger = true;
    foreach (int item in array)
    {
        if (trigger)
        {
            firstMin = item;
            trigger = false;
        }
        else
        {
            if (firstMin > item)
                firstMin = item;
        }
    }
    return firstMin;
}

int SecondMax(int[] array, int secondMax, int firstMax, int firstMin)    //находим второй максимум
{
    int firstMaxArray = FirstMax(array, firstMax);
    secondMax = FirstMin(array, firstMin);
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > secondMax && array[i] != firstMaxArray) secondMax = array[i];
    }
    return secondMax;
}

int SecondMin(int[] array, int secondMin, int firstMax, int firstMin)    //находим второй минимум
{
    int firstMinArray = FirstMin(array, firstMin);
    secondMin = FirstMax(array, firstMax);
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < secondMin && array[i] != firstMinArray) secondMin = array[i];
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
int firstMax = 0;
int firstMin = 0;
int secondMax = 0;
int secondMin = 0;
PrintArray(array);
System.Console.Write($" второй максимум равен: {SecondMax(array, secondMax, firstMax, firstMin)},");
System.Console.Write($" а второй минимум равен: {SecondMin(array, secondMin, firstMax, firstMin)}");