/*Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int Read(string coordinate)
{
    Console.Write($"Enter the coordinates {coordinate}: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

double Distance()
{
    int x = Read("X1");
    int y = Read("Y1");
    int z = Read("Z1");
    int x2 = Read("X2");
    int y2 = Read("Y2");
    int z2 = Read("Z2");

    double distance = Math.Round(Math.Sqrt(Math.Pow(x2-x, 2) + Math.Pow(y2 - y, 2) + Math.Pow(z2 - z, 2)), 2);
    return distance;
}

void Decision()
{
    double d=Distance();
    Console.WriteLine($"Distance between points in 3D space = {d}");
}

Decision();