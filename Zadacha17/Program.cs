// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

int Quoter(int Xin, int Yin)
{
    if (Xin>0 && Yin>0) return 1;
    if (Xin<0 && Yin>0) return 2;
    if (Xin<0 && Yin<0) return 3;
    if (Xin>0 && Yin<0) return 4;
    return 0;
}

Console.Write("Введи  координату Х ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи  координату Y ");
int Y = Convert.ToInt32(Console.ReadLine());

int quorter = Quoter(X,Y);
string result = quorter>0?
                    $"чертверть {quorter}"
                    :"некорректные данные";
Console.Write(result);