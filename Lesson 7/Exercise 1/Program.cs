// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
int Prompt(string massage)
{
    Console.Write(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void CreateArray(double[,] table)
{
for(int i = 0; i < table.GetLength(0); i++)
{
    for(int j = 0; j < table.GetLength(1); j++)
{
    table[i, j] = Math.Round((new Random().Next(10, 100) + new Random().NextDouble()), 2);
}
}
}
void PrintArray(double[,] table)
{
       for(int i = 0; i < table.GetLength(0); i++)
    {
       for(int j = 0; j < table.GetLength(1); j++)
       {
        Console.Write($" {table[i,j]}");
    }
    Console.WriteLine();
}
}
int m = Prompt("Введите количество строк массива: ");
int n = Prompt("Введите количество столбцов массива: ");
double[,] array = new double[m, n];
CreateArray(array);
PrintArray(array);