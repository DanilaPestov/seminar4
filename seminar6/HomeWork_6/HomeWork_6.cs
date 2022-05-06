//Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

Console.Write("Введите ваши числа через запятую: ");
string M = Console.ReadLine();
string[] arr = M.Split(",");
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    int num = int.Parse(arr[i]);
    if (num > 0) count++;
}
Console.WriteLine($"Колличество чисел больше '0' -> {count}");

//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.Write("Введите координату точки b1: ");
double b1 = double.Parse(Console.ReadLine()); 
Console.Write("Введите координату точки k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату точки b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату точки k2: ");
double k2 = double.Parse(Console.ReadLine());
double x=(b2-b1)/(k1-k2);
double y=k1*x+b1;
if (k1==k2) Console.WriteLine("прямые параллельны");
else Console.WriteLine($"Точка пересечения двух прямых ({x};{y})");