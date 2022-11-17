// Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции.
// * Доп сложность, “введите количество элементов массива”, 
// “Введите минимальный порог случайных значений”, 
// “Введите максимальный порог случайных значений”

int Prompt(string massage)
{
    Console.Write(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[] CreateArray(int length, int min, int max)
{
    int[] numberArray = new int[length];
for(int i = 0; i < length; i++)
{
    numberArray[i] = new Random().Next(min, max+1);
}
return numberArray;
}
void PrintArray(int[] newArray)
{
    Console.Write($"{newArray[0]}");
    for(int i = 1; i < newArray.Length; i++)
    {
        Console.Write($" {newArray[i]}");
    }
}
int Num = Prompt("Введите число массива: ");
int Min = Prompt("Введите минимальное число массива: ");
int Max = Prompt("Введите максимальное число массива: ");
Console.WriteLine($"Массив со случайными числами длиной в {Num} цифр, минимальное значение {Min}, максимальное значение {Max}");
int[] MaxArray = CreateArray(Num, Min, Max);
PrintArray(MaxArray);