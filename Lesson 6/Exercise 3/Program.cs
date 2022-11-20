// Найдите максимальное значение в матрице по каждой строке, 
// получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

void CreateArray(int[,] table)
{
for(int i = 0; i < table.GetLength(0); i++)
{
    for(int j = 0; j < table.GetLength(1); j++)
{
    table[i, j] = new Random().Next(10, 100);
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
int SumMaxNumber(int[,] table)
{
    int sum = 0;
    
    for(int j = 0; j < table.GetLength(0); j++)
    {
        int max = table[j, 0];
        for(int i = 0; i < table.GetLength(1); i++)
        if(max < table[j, i])
        {
            max = table[j, i];
        }
        sum += max;
    }
    return sum;
}
int SumMinNumber(int[,] table)
{
    int sum2 = 0;
    
    for(int i = 0; i < table.GetLength(1); i++)
    {
        int min = table[0, i];
        for(int j = 0; j < table.GetLength(0); j++)
        if(min > table[j, i])
        {
            min = table[j, i];
        }
        sum2 += min;
    }
    return sum2;
}
int[,] array = new int[5, 5];
CreateArray(array);
PrintArray(array);
 Console.WriteLine();
Console.WriteLine($"Сумма максимумов равна: {SumMaxNumber(array)}");
Console.WriteLine($"Сумма минимумов равна: {SumMinNumber(array)}");
Console.Write($"Разница равна:");
Console.WriteLine(SumMaxNumber(array) - SumMinNumber(array));