//  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//  Пример:
//  A (3,6,8); B (2,1,-7), -> 15.84
//  A (7,-5, 0); B (1,-1,9) -> 11.53

double dotX1 = InputInt($"Ведите координату X1 для точки A");
double dotY1 = InputInt($"Ведите координату Y1 для точки A");
double dotZ1 = InputInt($"Ведите координату Z1 для точки A");
double dotX2 = InputInt($"Ведите координату X2 для точки B");
double dotY2 = InputInt($"Ведите координату Y2 для точки B");
double dotZ2 = InputInt($"Ведите координату Z2 для точки B");

double result = findLenght(dotX1, dotX2, dotY1, dotY2, dotZ1, dotZ2);
System.Console.WriteLine($"Растояние между точками по координатам А({dotX1}, {dotY1}, {dotZ1}) и B({dotX2}, {dotY2}, {dotZ2}) равно: {result:F2}");

double InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = System.Console.ReadLine();
    double result = Convert.ToDouble(inputValue);
    return result;
}

double findLenght(double xOne, double xTwo, double yOne, double yTwo, double zOne, double zTwo)
{
    double cathetX = Math.Pow(xOne - xTwo, 2);
    double cathetY = Math.Pow(yOne - yTwo, 2);
    double cathetZ = Math.Pow(zOne - zTwo, 2);
    double hypotenuse = Math.Sqrt(cathetX + cathetY + cathetZ);
    return hypotenuse;
}