// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату X точки A:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки A:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки A:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X точки B:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки B:");
int z2 = Convert.ToInt32(Console.ReadLine());

double squareX= Math.Pow(x2-x1, 2);
double squareY= Math.Pow(y2-y1, 2);
double squareZ= Math.Pow(z2-z1, 2);

double length = Math.Sqrt(squareX+squareY+squareZ); 
length = Math.Round(length, 2);
Console.WriteLine($"Растояние между точками A и B в 3D пространстве {length}");
