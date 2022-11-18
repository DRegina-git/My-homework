// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateArray(int length, int min, int max)
{
    int[] tempArray = new int[length];
    for(int i = 0; i < length; i++)
{
    tempArray[i] = new Random().Next(min, max);
}
return tempArray;
}

void PrintArray(int[] array)
{
    Console.Write($"{array[0]}");
    for(int i = 1; i < array.Length; i++)
    {
       Console.Write($", {array[i]}");
    }
}
int Sum(int[] array)
{
    int sum = 0;
for (int i = 1; i < array.Length; i++)
{
if (i % 2 != 0)
{
sum += array[i];
}
}
return sum;
}
int len = 10;
int min = 1;
int max = 10;
int[] array = CreateArray(len, min, max);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {Sum(array)}");