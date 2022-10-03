//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Power(int number1, int number2)
{
    int index = 2;
    int result = number1;
    while(index <= number2)
    {
        result = result * number1;
        index = index + 1;
    }
    return result;
}

Console.Clear();

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

int N = Power(A, B);
Console.WriteLine(N);