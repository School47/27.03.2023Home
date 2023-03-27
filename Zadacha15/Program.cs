// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
bool IsThisDayWeekend(int putNumberInsideMe)
{
    return((putNumberInsideMe==6 ||putNumberInsideMe==7)? true :false);
}

Console.Write("Введите  цифру, обозначающую день недели: ");
int N = Convert.ToInt32(Console.ReadLine());

if (IsThisDayWeekend(N))
{
    Console.Write("да");
}
else
{
    Console.Write("нет");
}

