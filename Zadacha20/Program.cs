
// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
double Distance (int X1Coord, int Y1Coord, int X2Coord,int Y2Coord)
{
    return Math.Sqrt((X1Coord-X2Coord)*(X1Coord-X2Coord)+(Y1Coord-Y2Coord)*(Y1Coord-Y2Coord)); 
}

Console.Write("Введи  X1:");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи  Y1:");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи  X2:");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи  Y2:");
int Y2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(X1,Y1,X2,Y2);
Console.Write(Math.Round(result,2,MidpointRounding.ToZero));
