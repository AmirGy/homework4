// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int DegreeNum(int arg1, int arg2)
{
    int T = A;
    for (int i = 1; i < B; i++)
    {
        A = A * T;
    }
    return A;
}

Console.Write(DegreeNum(A, B));