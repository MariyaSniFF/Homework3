// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты X первой точки");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y первой точки");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z первой точки");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты X второй точки");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y второй точки");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z второй точки");
int zB = Convert.ToInt32(Console.ReadLine());

int A = xB - xA;
int B = yB - yA;
int C = zB - zA;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
