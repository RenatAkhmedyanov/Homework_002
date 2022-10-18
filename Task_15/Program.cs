Console.WriteLine("Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");

Console.Write("Введите число от 1 до 7: ");
int input = int.Parse(Console.ReadLine()!);

bool IsCorrectInput(int input)
{
    return input >= 1 && input <= 7;
}
bool IsWeekend(int input)
{
    return input == 6 || input == 7;
}

if (IsCorrectInput(input))
{
    if (IsWeekend(input))
    {
        Console.WriteLine("Этот день является выходным.");
    }
    else
    {
        Console.WriteLine("Этот день является рабочим.");
    }
}
else
{
    Console.WriteLine("Некорректный ввод, введите цифру от 1 до 7!");
}