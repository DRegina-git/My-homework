// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

int Prompt(string message)
{
Console.Write(message);
int temp = int.Parse(Console.ReadLine());
return temp;
}
double[] CreateArray(int length, int min, int max)
{
    double[] tempArray = new double[length];
    for(int i = 0; i < length; i++)
{
    tempArray[i] = Math.Round((new Random().Next(min, max) + new Random().NextDouble()), 2);
}
return tempArray;
}

void PrintArray(double[] array)
{
    Console.Write($"{array[0]}");
    for(int i = 1; i < array.Length; i++)
    {
       Console.Write($"; {array[i]}");
    }
}
double MaxDigit(double[] array)
{
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
}
return max;
}
double MinDigit(double[] array)
{
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
}
return min;
}
double Difference(double[] array)
{
    double max = MaxDigit(array);
    double min = MinDigit(array);
    double diff = Math.Round((max - min), 2);
    return diff;
}
int len = Prompt("Введите длину массива: ");
int min = Prompt("Введите минимальное значение массива: ");
int max = Prompt("Введите максимальное значение массива: ");
double[] newArray = CreateArray(len, min, max);
PrintArray(newArray);
Console.WriteLine();
Console.WriteLine($"Разница между минимальным и максимальным значениями в массиве равна {Difference(newArray)}");