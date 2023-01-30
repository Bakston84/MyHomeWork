//  Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
//  Пример:
//  [3, 7, 23, 12] -> 19
//  [-4, -6, 89, 6] -> 0

int[] array = CreatArray(4);
PrintArray(array);

int[] CreatArray(int size)      //создаём массив генератором случайных чисел
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-99, 99);
    }
    return array;
}

int Sum(int sum)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sum = sum + array[i];
    }
    return sum;
}

void PrintArray(int[] array)    //выводим результат массива
{
    int result = 0;
    int sum = 0;
    System.Console.Write("В массиве [");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            result++;
        System.Console.Write(array[i]);
        if (i != array.Length - 1)
            System.Console.Write(", ");
    }
    sum = Sum(sum);
    System.Console.WriteLine($"] сумма элементов на нечётных адресах равна: {sum}");
}