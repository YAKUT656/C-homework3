// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
int n = 1;

while (n<=number)
{
    Console.Write($"{n*n*n} ");
    n++;
}