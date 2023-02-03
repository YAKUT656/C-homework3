// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine()!);

int A = number / 10000;
int B = ((number / 1000) - A *10);
int C = ((number / 1000) - A * 100 - B *10);
int D = ((number / 10)- A *1000 - B * 100 - C * 10);

if (number<100000 & number>9999)
{
    if ()
}