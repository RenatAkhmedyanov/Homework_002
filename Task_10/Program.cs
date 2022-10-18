Console.WriteLine("Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");

Console.Write("Введите трехзначное число: ");
int input = int.Parse(Console.ReadLine()!);

void GetSecondDigit(int input)
{
    if (IsCorrectInput(input))
    {
        Console.WriteLine("Ошибка ввода. Введите трехзначное число!");
    }
    else
    {
        int secondDigit = (input / 10) % 10;
        Console.WriteLine("Вторая цифра введеного числа: " + secondDigit);
    }
}
bool IsCorrectInput(int input)
{
    return input < 100 || input > 999;
}
GetSecondDigit(input);