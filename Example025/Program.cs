// Программа, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.WriteLine("Введите число А: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine()!);

int GetDegreeFromAToB(int a)
{
    int result = Convert.ToInt32(Math.Pow(numberA, numberB));
    return result;
}

if (numberB > 0)
{
int result = GetDegreeFromAToB(numberA);
Console.WriteLine("Результат: " + result);
}
else
{
    Console.WriteLine("Число B не является натуральным");
}