void Print(int[] massiv)
{
    Console.Write("Дан массив чисел: ");
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write(massiv[i] + " ");
    }
    Console.WriteLine();
}
// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] mas = new int[4];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = new Random().Next(100, 1000);
}
Print(mas);
int num = 0;
for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] % 2 == 0)
    {
        num++;
    }
}
Console.WriteLine("Количество четных чисел в массиве: " + num);

// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0

int[] mas = new int[4];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = new Random().Next(0, 30);
}
Print(mas);
int num = 0;
for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] % 2 != 0)
    {
        num+=mas[i];
    }
}
Console.WriteLine("Сумма нечетных элементов в массиве: " + num);

// Задача 38: 
// Задайте с. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] mas = new int[5];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = new Random().Next(-10, 100);
}
Print(mas);
int max = mas[0];
int min = mas[0];
for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] < min)min = mas[i];
    if (mas[i] > max) max = mas[i];

}
Console.WriteLine($"Максимальный элемент: {max}");
Console.WriteLine($"Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max - min}");