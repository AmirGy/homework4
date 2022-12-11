// Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.
Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int C = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите четвертое число: ");
int D = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите пятое число: ");
int E = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите шестое число: ");
int F = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите седьмое число: ");
int G = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите восьмое число: ");
int H = Convert.ToInt32(Console.ReadLine());

int[] Array = { A, B, C, D, E, F, G, H };

void PrintArray(int[] Array)
{
    Console.Write("Данный массив состоит из: ");
    int count = 8;
    int i = 0;
    while (i <= count)
    {
        Console.Write($"{Array[i]} ");
        i++;
    }
}

PrintArray(Array);