// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int Prompt(string massage)
{
    Console.Write(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void CreateArray(int[,] table)
{
for(int i = 0; i < table.GetLength(0); i++)
{
    for(int j = 0; j < table.GetLength(1); j++)
{
    table[i, j] = new Random().Next(1, 10);
}
}
}
void PrintArray(int[,] table)
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
int[,] array = new int[m, n];
CreateArray(array);
PrintArray(array);

    int[] sum = new int[m];
      for(int i = 0; i < m; i++)
    {
       for(int j = 0; j < n; j++)
       {
        sum[i] += array[j, i];
    }
}
Console.WriteLine("Среднее арифметическое каждого столбца:");
foreach(double elem in sum)
{
Console.WriteLine(elem/ m);
} 
