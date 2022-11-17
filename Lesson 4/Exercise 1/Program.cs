// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int Prompt(string massage)
{
    Console.Write(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    
    return number;
}
int numberA = Prompt("Введите число А: ");
int numberB = Prompt("Введите число B: ");
int degree = numberA;

for(int i = 1; i < numberB; i++) {
degree = degree * numberA;
}
Console.WriteLine($"Число А в степени числа В равно: {degree}");