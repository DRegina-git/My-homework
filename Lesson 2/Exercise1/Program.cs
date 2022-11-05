// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string massage)
{
    Console.Write(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
bool ValidateNumber(int number)
{
    if(number < 100 || number >= 1000)
    {
        Console.WriteLine("Это не трехзначное число");
        return false;
    }
    return true;
}
int number = Prompt("Введите трехзначное число: ");
if(ValidateNumber(number))
{
    int middleDigit = number / 10 % 10;
    Console.WriteLine($"Вторая цифра числа {number} равна {middleDigit}");
}