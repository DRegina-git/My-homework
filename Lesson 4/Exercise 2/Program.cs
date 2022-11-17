// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе. Реализовать через функции

int Prompt(string massage)
{
    Console.Write(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int SumDigit(int number)
{
int result = 0;
while (number > 0)
{
result += number % 10;
number = number / 10;
}
return result;
}
int number = Prompt("Введите число: ");
int result = SumDigit(number);
Console.WriteLine($"Сумма цифр заданного числа равна {result}");