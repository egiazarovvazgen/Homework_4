// Программа, которая принимает на вход число и выдаёт сумму цифр в числе

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number < 0) number = Math.Abs(number);

int GetSumFromDigits(int a)
{
    int result = 0;
    while (number > 0)
    {
        int digit = number % 10;
        result = result + digit;
        number = number / 10;
    }
    return result;
}

int result = GetSumFromDigits(number);
Console.WriteLine("Результат: " + result);