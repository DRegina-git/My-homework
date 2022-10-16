// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число ");
String? num1 = Console.ReadLine();
int a = Convert.ToInt32(num1);
Console.Write("Введите второе число ");
String? num2 = Console.ReadLine();
int b = Convert.ToInt32(num2);
Console.Write("Введите третье число ");
String? num3 = Console.ReadLine();
int c = Convert.ToInt32(num3);

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine (max);