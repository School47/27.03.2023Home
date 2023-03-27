// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
bool IsNumberBigEnought(int putInsideMeNumber)
{
    return (putInsideMeNumber < 100 ? false : true);
}

int MakeNumber3Digit(int putInsideMeNumber)
{
    while (putInsideMeNumber > 999)
    {
        putInsideMeNumber = putInsideMeNumber / 10;
    }
    return putInsideMeNumber;
}

Console.Write("Введите  число  N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (IsNumberBigEnought(N))
{
    int threeDigitNumber = MakeNumber3Digit(N);
    Console.Write(threeDigitNumber % 10);
}
else
{
    Console.Write("Третьей цифры нет"); // cuz number less than 100
}
