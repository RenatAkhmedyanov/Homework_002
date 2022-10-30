Console.WriteLine("Программа, считывающая с пользовательского ввода целое число n (неотрицательное), выводящее это число в консоль вместе с правильным образом изменённым словом 'программист'.");

Console.Write("Введите количество программистов: ");
int input = int.Parse(Console.ReadLine()!);
int check = input % 10;
int secondCheck = input % 100; //для чисел, который заканчиваются на 11, 12, 13, 14

void HasCorrectEnding(int input, int check)
{
    if (secondCheck >= 10 && secondCheck <= 20)
    {
        Console.WriteLine("В комнате " + input + " программистов.");
    }
    else
    {
        if (check == 1)
        {
            Console.WriteLine("В комнате " + input + " программист.");
        }
        if (check >= 2 && check <= 4)
        {
            Console.WriteLine("В комнате " + input + " программиста.");
        }
        if (check >= 5 || check == 0)
        {
            Console.WriteLine("В комнате " + input + " программистов.");
        }
    }

}
HasCorrectEnding(input, check);