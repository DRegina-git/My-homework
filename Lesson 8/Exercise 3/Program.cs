// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
int Prompt(string massage)
{
    Console.Write(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int m = Prompt("Введите число строк 1-й матрицы: ");
int n = Prompt("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int a = Prompt("Введите число столбцов 2-й матрицы: ");
int range = Prompt("Введите диапазон случайных чисел: от 1 до ");

int[,] Martrix1 = new int[m, n];
CreateArray(Martrix1);
Console.WriteLine($"\n Первая матрица:");
WriteArray(Martrix1);

int[,] Martrix2 = new int[n, a];
CreateArray(Martrix2);
Console.WriteLine($"\n Вторая матрица:");
WriteArray(Martrix2);

int[,] resultMatrix = new int[m, a];

MultiplyMatrix(Martrix1, Martrix2, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] Martrix1, int[,] Martrix2, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int b = 0; b < Martrix1.GetLength(1); b++)
            {
                sum += Martrix1[i, b] * Martrix2[b, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}
void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}