// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random(). Next (100, 1000);
// int firstDigit = number / 100;
// int middleDigit = number / 10 % 10;
// int lastDigit = number % 10;
//Console.WriteLine($"{number} -> {firstDigit}{lastDigit}");
int number2 = int.Parse(number.ToString().Remove(1, 1));
Console.WriteLine($"{number} -> {number2}");