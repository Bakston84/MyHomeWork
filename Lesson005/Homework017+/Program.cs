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

int SecondMax(int[] array, int secondMax)    //находим второй максимум
{
    int firstMaxArray = array.Max();
    secondMax = array.Min();
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > secondMax && array[i] != firstMaxArray) secondMax = array[i];
    }
    return secondMax;
}

int SecondMin(int[] array, int secondMin)    //находим второй минимум
{
    int firstMinArray = array.Min();
    secondMin = array.Max();
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
int secondMax = 0;
int secondMin = 0;
PrintArray(array);
System.Console.Write($" второй максимум равен: {SecondMax(array, secondMax)},");
System.Console.Write($" а второй минимум равен: {SecondMin(array, secondMin)}");