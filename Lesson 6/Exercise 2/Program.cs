// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double Prompt(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}
const int b = 1;
const int k = 0;
const int x = 0;
const int y = 1;

void InputCoeff(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"Введите коэффициенты {i + 1} уравнения (y = k * x + b):\n ");
        Console.WriteLine();
        array[i, k] = Prompt("Введите коэффициент k: ");
        array[i, b] = Prompt("Введите коэффициент b: ");
        
    }
}
double[] FindPoint(double[,] num)
{
    double[] point = new double[2];
    point[x] =  (num[1,b] - num[0,b]) / (num[0,k] - num[1,k]);
    point[y] = num[0,k] * point[x] + num[0,b];
    return point;
}
double[,] findCross = new double[2,2];
InputCoeff(findCross);
double[] crossPoint = FindPoint(findCross);
Console.WriteLine();
Console.WriteLine($"Точка пересечения координат: {crossPoint[x]}, {crossPoint[y]}");