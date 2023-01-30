//  Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
//  Пример:
//  [345, 897, 568, 234] -> 2

int[] array = CreatArray(4);
PrintArray(array);

int[] CreatArray(int size)      //создаём массив генератором случайных чисел
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 999);
    }
    return array;
}

void PrintArray(int[] array)    //выводим результат массива
{
    int result = 0;
    System.Console.Write("В массиве [");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            result++;
        System.Console.Write(array[i]);
        if (i != array.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine($"] чётных чисел: {result}");
}