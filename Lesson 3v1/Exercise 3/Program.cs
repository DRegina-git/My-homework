// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

int Prompt(string massage)
{
    Console.Write(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
bool ValidateNumber(int number)
{
    if(number < 1)
    {
        Console.WriteLine("Необходимо ввести число > 1");
        return false;
    }
    return true;
}
int number = Prompt("Введите число: ");
if(ValidateNumber(number))
{
        for(int i = 1; i <= number; i++)
       {
       int stepen = 3;
       Console.WriteLine($"{i}^{stepen} = {Math.Pow(i,stepen)}");
       }
       
    }

