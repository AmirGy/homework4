// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11 82 -> 10 9012 -> 12

Console.Write("Введмте число: ");
int num = Convert.ToInt32(Console.ReadLine());
int SumNum(int arg)
{
    int sum = 0;
    while (num >= 1)
    {
        int last = num % 10;
        sum = sum + last;
        num = num / 10;
    }
    return sum;
}

Console.Write(SumNum(num));