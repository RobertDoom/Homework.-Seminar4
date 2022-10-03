//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

void FillArray(int[] assemblage)
{
    int lenght = assemblage.Length;
    int index = 0;
    while (index < lenght)
    {
        assemblage[index] = new Random().Next(1, 100);
        index = index + 1;
    }
}

void PrintArray(int[] col)
{
    Console.Write($"[");
    Console.Write(String.Join(", ", col));
    Console.Write($"]");
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);