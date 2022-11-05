// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

int Prompt(string message)
{
Console.Write(message);
int number = Convert.ToInt32(Console.ReadLine());
return number;
}
int number = Prompt("Введите число: ");
if (number > 99)
{
int indexDigit = number.ToString()[2];
Console.WriteLine($"Третья цифра числа {number} равна {number.ToString()[2]}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
