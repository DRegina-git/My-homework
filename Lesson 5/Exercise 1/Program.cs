// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray(int length, int min, int max)
{
    int[] tempArray = new int[length];
    for(int i = 0; i < length; i++)
{
    tempArray[i] = new Random().Next(min,max+1);
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
int CountDigit(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int len = 15;
int min = 100;
int max =1000;
int[] array = CreateArray(len, min, max);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве равно {CountDigit(array)}");