Console.WriteLine("Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");

Console.Write("Введите целое число: ");
int input = int.Parse(Console.ReadLine()!);

bool HasThreeDigits(int input)
{
    return input < 100;
}
void GetThirdDigit(int input)
{
    while (input > 1000)
    {
        input = input / 10;
    }
    int result = input % 10;
    Console.WriteLine("Третья цифра введенного числа: " + result);
}

if (HasThreeDigits(input))
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    GetThirdDigit(input);
}


