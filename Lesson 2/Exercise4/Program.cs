// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string message)
{
Console.Write(message);
int number = Convert.ToInt32(Console.ReadLine());
return number;
}
int number = Prompt("Введите цифру, обозначающую день недели: ");
if(number < 1 || number > 7)
{
Console.WriteLine("Это цифра не обозначает день недели");
}
else if(number == 6 || number == 7)
{
Console.WriteLine("Да, это выходной день");
}
else 
{
Console.WriteLine("Нет, это не выходной день");
}