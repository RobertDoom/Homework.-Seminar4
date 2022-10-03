//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

int SumOfDigits(int number)
{
    int result = 0;
    while (Math.Abs(number) > 0)
    {
        result = result + number % 10;
        number = number /10;
    }
    return result;
}
Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int sum = SumOfDigits(N);

Console.WriteLine(Math.Abs(sum));