Console.WriteLine("Программа, которая принимает на вход целое число любой разрядности и удаляет вторую цифру слева направо этого числа.");

Console.Write("Введите целое число: ");
int input = int.Parse(Console.ReadLine()!);

if (input <= 9)
{
    Console.WriteLine("Второй цифры нет.");
}
else
{
    void DeleteSecondDigit(int input)
    {
        int sum = 0;
        int numberPosition = 1;
        while (input > 99)
        {
            int div = input % 10;
            sum = sum + div * numberPosition;
            numberPosition = numberPosition * 10;
            input = input / 10;
        }
        input = input / 10;
        int result = input * numberPosition + sum;
        Console.WriteLine("Итоговое число после удаления второй цифры: " + result);
    }
    DeleteSecondDigit(input);
}


