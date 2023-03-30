// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

string Spreadsheet(int nNum)
{
    string spreadsheetResult = "____________\n";
    for (int i = 1; i <= nNum; i++)
    {
        spreadsheetResult = spreadsheetResult + $"|{i,5}|{i * i,5}| \n";
    }
    spreadsheetResult = spreadsheetResult+ "-------------";
    return spreadsheetResult;
}

Console.Write("Введи  число N:");
int n = Convert.ToInt32(Console.ReadLine());

string result = Spreadsheet(n);
Console.Write(result);
