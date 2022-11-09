// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

int Prompt(string massage)
{
    Console.Write(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
double x1 = Prompt("Введите координаты первой точки по оси x: ");
double y1 = Prompt("Введите координаты первой точки по оси y: ");
double z1 = Prompt("Введите координаты первой точки по оси z: ");
double x2 = Prompt("Введите координаты второй точки по оси x: ");
double y2 = Prompt("Введите координаты второй точки по оси y: ");
double z2 = Prompt("Введите координаты второй точки по оси z: ");
double Distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console. WriteLine($"Расстояние между двумя точками равно: {Distance}");