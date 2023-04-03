// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int i = GetRandom();

Console.WriteLine(i);
Console.WriteLine(ShowSecondDigit(i));

int GetRandom()
{
    return new Random().Next(100, 1000);
}

int ShowSecondDigit(int number)
{
    int firstNumber = number % 100;
    int secondNumber = firstNumber / 10;
    int result = secondNumber;
    return result;
}