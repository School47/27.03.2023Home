﻿// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

 string Quoter(int quoterNumber)
{
    if (quoterNumber==1) return " X>0, Y>0";
    if (quoterNumber==2) return " X<0, Y>0";
    if (quoterNumber==3) return " X<0, Y<0";
    if (quoterNumber==4) return " X>0, Y<0";
    return "Неправильный номер четверти";
}

Console.Write("Введи  номер четверти ");
int quorterNumberInput = Convert.ToInt32(Console.ReadLine());
String result = Quoter(quorterNumberInput);
Console.Write(result);
