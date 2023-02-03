// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();

Console.Write("Введите координаты X1");
double X1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координаты Y1");
double Y1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координаты Z1");
double Z1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координаты X2");
double X2 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координаты Y2");
double Y2 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координаты Z2");
double Z2 = Convert.ToDouble(Console.ReadLine()!);

double x = Math.Pow(X1-X2,2) + Math.Pow(Y1-Y2,2) + Math.Pow(Z1-Z2,2);

double len = Math.Sqrt(x);

Console.WriteLine(Math.Round(len,2));
