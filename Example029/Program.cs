// Программа, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку

int[] array = new int[8];

void FillArray(int[] collection)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
}

void PrintArray(int[] col)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}

FillArray(array);
Console.WriteLine("Массив: ");
PrintArray(array);
Console.WriteLine();