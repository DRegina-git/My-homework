// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь
int Prompt(string message)
{
Console.Write(message);
int temp = int.Parse(Console.ReadLine());
return temp;
}
int[] InputNum(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt("Введите число: ");
    }
    return array;
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
    for (int i = 0; i < array.Length; i++)
{
if (array[i] > 0)
{
count += 1;
}
}
return count;
}
int m = Prompt("Введите количество чисел в массиве: ");
int[] array = InputNum(m);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество чисел больше нуля равно: {CountDigit(array)}");

