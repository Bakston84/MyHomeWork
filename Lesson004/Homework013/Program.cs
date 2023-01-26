//  Напишите программу, которая выводит массив из элементов, заполненный случайными числами
//  Оформить заполнение массива и вывести в виде функции.
//  Дополнительго: задать кол-во элеменентов массива, минимальный и максимальный порог случайных значений
//  Пример:
//  1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//  6, 1, 33 -> [6, 1, 33]

int numberArrayElements = InputInt("Введите количество элементов в массиве");
int minThreshold = InputInt("Введите минимальный порог случайных значений");
int maxThreshold = InputInt("Введите максимальный порог случайных значений");
int[] array = CreatArray(numberArrayElements);
PrintArray(array);

int InputInt(string message)    //вводим необходимые данные
{
    System.Console.Write(message + " > ");
    string? inputValue = System.Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int[] CreatArray(int size)  //создаём массив генератором случайных чисел
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < numberArrayElements; i++)
    {
        array[i] = rnd.Next(minThreshold, maxThreshold);
    }
    return array;
}

void PrintArray(int[] array)    //выводим результат массива
{
    System.Console.Write($"Массив из {numberArrayElements} элементов с интервалом случайного числа от {minThreshold} до {maxThreshold}, равен: [");
    for (int i = 0; i < numberArrayElements; i++)
    {
        if (i == numberArrayElements - 1)
        {
            System.Console.Write($"{array[i]}");
        }
        else
        {
            System.Console.Write($"{array[i]}, ");
        }
    }
    System.Console.Write("]");
}