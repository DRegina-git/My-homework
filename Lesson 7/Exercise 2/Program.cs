// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int Prompt(string massage)
{
    Console.Write(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void CreateArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($" {table[i, j]}");
        }
        Console.WriteLine();
    }
}
int m = Prompt("Введите количество строк массива: ");
int n = Prompt("Введите количество столбцов массива: ");
int[,] array = new int[m, n];
CreateArray(array);
PrintArray(array);
int a = Prompt("Введите координаты строки: ");
int b = Prompt("Введите координаты столбца: ");
if ((a > array.GetLength(0)) | (b > array.GetLength(1)) | (a < 0) | (b < 0))
{
    Console.WriteLine("Такого элемента в массиве нет");
}
else
{
    Console.WriteLine($"{array[a, b]}");
}