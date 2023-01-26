//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//  Пример:
//  3, 5 -> 243 (3⁵)
//  2, 4 -> 16

double x = InputInt("Введите число");
double degree = InputInt("Введите степень");
double raise = 0;
RaiseDegree(raise);

double InputInt(string message)    //вводим необходимые данные
{
    System.Console.Write(message + " > ");
    string? inputValue = System.Console.ReadLine();
    double result = Convert.ToDouble(inputValue);
    return result;
}

void RaiseDegree(double raise)  //функция возведения в степень
{
    raise = Math.Pow(x, degree);
    System.Console.WriteLine($"Число {x} в степени {degree} равно: {raise}");
}