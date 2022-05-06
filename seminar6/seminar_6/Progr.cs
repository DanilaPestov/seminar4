// // переворачиваем одномерный массив
// int[] mass = new int[10];
// for (int i = 0; i < mass.Length; i++)
// {
//     mass[i] = new Random().Next(0, 100);
//     Console.Write(mass[i] + " ");
// }

// Console.WriteLine();
// int save = 0;
// for (int i = 0; i < mass.Length / 2; i++)
// {
//     save = mass[i];
//     mass[i] = mass[mass.Length - 1 - i];
//     mass[mass.Length - 1 - i] = save;
// }
// for (int i = 0; i < mass.Length; i++)
// {
//     Console.Write(mass[i] + " ");
// }
// Console.WriteLine();

//// принимает 3 числа и сообщает может ли существовать треугольник с сторонами такой длины
// Console.WriteLine("Введите число 1: ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число 2: ");
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число 3: ");
// int c = int.Parse(Console.ReadLine());

// if (a < b + c && b < a + c && c < a + b)
// Console.WriteLine("такой треугольник может существовать");
// else Console.WriteLine("треугольника нет");

//// преобразование десятичного числа в двоичное
// Console.WriteLine("Введите число: ");
// int a = int.Parse(Console.ReadLine());
// string m = String.Empty;
// while (a > 0)
// {
//     m = a % 2 + m;
//     a = a / 2;
// }
// Console.WriteLine(m);

//// числа фибоначчи без рекурсии
// void Print(int[] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         Console.Write(matr[i]+ " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите число: ");
// int N = int.Parse(Console.ReadLine());
// int f1 = 0;
// int f2 = 1;
// Console.Write($"ряд чисел фибоначчи: {f1} {f2} ");
// int fib;
// for (int i = 1; i < N-1; i++)
// {
//     fib = f1 + f2;
//     f1 = f2;
//     f2 = fib;
//     Console.Write(fib + " ");
// }
// Console.WriteLine();

// int[] mass = new int[N];
// mass[0] = 0;
// mass[1] = 1;
// for (int i = 2; i < mass.Length; i++)
// {
//     mass[i] = mass[i - 1] + mass[i - 2];
// }
// Console.Write("ряд чисел фибоначчи: ");
// Print(mass);

///// копируем массив
void Print(int[] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write(matr[i]+ " ");
    }
    Console.WriteLine();
}
void Massiv(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(0,100);
        //Console.Write($"{mas[i]} ");
    }
    //Console.WriteLine();
}
int[] mass=new int[11];
Massiv(mass);
Print(mass);
int[]mass2=new int [mass.Length];
for (int i = 0; i < mass.Length; i++)
{
    mass2[i]=mass[i];
}
Print(mass2);