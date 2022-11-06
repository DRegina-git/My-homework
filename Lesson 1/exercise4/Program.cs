// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число ");
String number = Console.ReadLine();
int a = Convert.ToInt32(number);
int i = 1;

while (i <= a)
{

    if(i % 2 == 0)
    {
Console.WriteLine("{0}", i);
    }
    i++;
}
