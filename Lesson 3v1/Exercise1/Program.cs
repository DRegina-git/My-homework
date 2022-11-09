//Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом. Без использования строк

int Prompt(string massage)
{
    Console.Write(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
bool ValidateNumber(int number)
{
    if(number < 10000 || number >= 100000)
    {
        Console.WriteLine("Это не пятизначное число ");
        return false;
    }
    return true;
}
int Reverse(int number)
{
    int result = 0;
    while(number > 0)
    {
        result = number % 10 + result * 10;
        number = number / 10;
    }
    return result;
}
bool CheckPalindrome(int number)
{
   return Reverse(number) == number;
}

int number = Prompt("Введите пятизначное число: ");
if (ValidateNumber(number))
{
    if (CheckPalindrome(number))

    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
else
{
    Console.WriteLine($"Число {number} не является полиндромом");
}

}
