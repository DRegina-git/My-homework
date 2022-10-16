// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число ");
String? num1 = Console.ReadLine();
int a = Convert.ToInt32(num1);
Console.Write("Введите второе число ");
String? num2 = Console.ReadLine();
int b = Convert.ToInt32(num2);

if(a > b)
{
    Console.Write("max = ");
    Console.WriteLine(num1);
    Console.Write("min = ");
    Console.WriteLine(num2);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(num2);
    Console.Write("min = ");
    Console.WriteLine(num1);
}
