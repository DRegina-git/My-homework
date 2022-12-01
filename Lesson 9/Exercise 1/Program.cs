// Задайте значения M и N. Напишите программу, которая выведет все чётные 
// натуральные числа в промежутке от M до N с помощью рекурсии.
int Prompt(string massage)
{
    Console.Write(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


void PrintNumbers(int m, int n)
{
    if (n < m)
    {
        return;
    }
    int i = 1;
  for(i = m; i <= n; i++)
  {
    if(i % 2 == 0)
    {
        Console.Write(i + " ");
    }
  }
}
int m = Prompt("Введите M: ");
int n = Prompt("Введите N: ");
PrintNumbers(m, n);