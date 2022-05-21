// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
int m = 3, n = 4;
double[,] mass = new double[m, n];
Random random = new Random();
void Print(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.NextDouble()*10;
            Console.Write("{0,6:F1}", array[i, j]);
        }
        Console.WriteLine();
    }
}

Print(mass);

// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет

int m = 3, n = 4;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Print(mass);
Console.WriteLine();

Console.Write("Введите номер строки: ");
int l = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int s = int.Parse(Console.ReadLine());
if (l<=mass.GetLength(0) & s<=mass.GetLength(1)) 
{
    Console.WriteLine($"Значение элемента: {mass[l-1,s-1]}");
}
else Console.WriteLine("такого элемента нет");

// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

int m = 3, n = 4;
int[,] mass = new int[m, n];
double []summ =new double [n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,6:F1}",array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Print(mass);
Console.WriteLine();

for (var i = 0; i < n; i++)
{
    for (var j = 0; j < m; j++)
    {
        summ[i] = summ[i] + mass[j, i];
    }
}
for (var i=0; i<n; i++)
{
    summ[i]=summ[i] / m;

    Console.Write("{0,6:F1}",summ[i]);
}
Console.WriteLine();
