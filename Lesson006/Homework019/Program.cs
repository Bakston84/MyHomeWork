// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Пример:
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int InputInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

void InputPoint(double[,] inputPoints)
{
    for (int i = 0; i < inputPoints.GetLength(0); i++)
    {
        for (int j = 0; j < inputPoints.GetLength(1); j++)
        {
            if (i == 0) System.Console.Write($"Введите точку k.");
            else System.Console.Write($"Введите точку b.");
            inputPoints[i, j] = InputInt($"{j + 1}");
        }
    }
}

double[,] inputPoints = new double[2, 2];
InputPoint(inputPoints);
double x = (inputPoints[1, 1] - inputPoints[1, 0]) / (inputPoints[0, 0] - inputPoints[0, 1]);
double y = inputPoints[0, 0] * x + inputPoints[1, 0];
System.Console.WriteLine($"Точкой пересечения двух прямых является: {x}; {y}");