// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int Prompt(string massage)
{
    Console.Write(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[,] CreateArray(int i, int j)
{
    int[,] array = new int[i, j];
    for (i = 0; i < array.GetLength(0); i++)
    {
        for (j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}
int[,] SortArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            int temp = j;
            for (temp = 0; temp < table.GetLength(1) - 1 - j; temp++)
            {
                if (table[i, temp] < table[i, temp + 1])
                    (table[i, temp], table[i, temp + 1]) = (table[i, temp + 1], table[i, temp]);
            }
        }
    }
    return table;
}
int i = Prompt("Введите количество строк массива: ");
int j = Prompt("Введите количество столбцов массива: ");
int[,] newArray = CreateArray(i, j);
PrintArray(newArray);
Console.WriteLine();
int[,] sortTable = SortArray(newArray);
PrintArray(sortTable);

