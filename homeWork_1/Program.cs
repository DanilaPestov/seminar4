// напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В
Console.WriteLine("возведём число 'А' в степень 'В'");
Console.Write("введите число 'А': ");
int A = int.Parse(Console.ReadLine());
Console.Write("введите степень 'B': ");
int B = int.Parse(Console.ReadLine());
int point = 1;

for (int i = 1; i <= B; i++)
{
    point *= A;
}
Console.WriteLine($"результат возведения: {point}");

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
Console.Write("Ищем сумму цифр в числе. ");
Console.WriteLine("Ваше число: ");
int A = int.Parse(Console.ReadLine());
int sum = 0;
while (A > 0)
{
    sum += A % 10;
    A /= 10;
}
Console.WriteLine($"сумма равна: {sum}");

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//исходя из примера в задаче:
int[] mas = new int[] {4,5,2,6,8,9,2,7};
Console.WriteLine("массив из 8 заданных элементов: ");
for (int i = 0; i < mas.Length; i++)
{
    Console.Write($"{mas[i]} ");
}
Console.WriteLine();

//программа задает 8 рандомных элементов:
int[] mas = new int[8];
Console.WriteLine("массив из 8 рандомных элементов: ");
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = new Random().Next(0,101);
    Console.Write($"{mas[i]} ");
}
Console.WriteLine();