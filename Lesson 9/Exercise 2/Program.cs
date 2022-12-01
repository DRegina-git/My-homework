// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N с помощью рекурсии.

int Prompt(string massage)
{
    Console.Write(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int SumNumbers(int m, int n)
{
    if (m == 0)
    {
        return (n * (n + 1)) / 2;
    }
    else if (n == 0)
    {
        return (m * (m + 1)) / 2;
    }
    else if (m == n)
    {
        return m;
    }
    else if (m < n)
    {
        return n + SumNumbers(m, n - 1);
    }
    else return n + SumNumbers(m, n + 1);
}
int m = Prompt("Введите M: ");
int n = Prompt("Введите N: ");
Console.WriteLine($"Сумма = {SumNumbers(m, n)}");





