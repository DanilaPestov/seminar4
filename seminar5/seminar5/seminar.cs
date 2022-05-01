// // функция печати
// void Print(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// ///////////////////////////////////////////////
// //сумма отрицательных и положительных чисел массива
// int[] mas = new int[12];

// Print(mas);

// for (int i = 0; i < mas.Length; i++)
// {
//     mas[i] = new Random().Next(-9, 10);
// }
// Print(mas);

// int summPos = 0;
// int summNeg = 0;
// for (int i = 0; i < mas.Length; i++)
// {
//     if (mas[i]>0)
//     {
//         summPos += mas[i];
//     }
//     else
//     {
//         summNeg += mas[i];
//     }
// }
// Console.WriteLine($"сумма положительных '{summPos}' и сумма отрицательных '{summNeg}'");

////////////////////////////////////////////////////////
// // Напишите программу замена элементов массива: 
// // положительные элементы замените на соответствующие отрицательные, и наоборот.
void txt(int[] massiv)
{
    Console.Write("Дан массив чисел: ");
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write(massiv[i] + " ");
    }
    Console.WriteLine();
}

// int[] mas = new int[8];
// for (int i = 0; i < mas.Length; i++)
// {
//     mas[i] = new Random().Next(-10, 11);
// }
// txt(mas);
// for (int i = 0; i < mas.Length; i++)
// {
//     mas[i]=-mas[i];
// }
// txt(mas);

// // Здайте массив. Напишите программу, которая определяет, 
// // присутствует ли заданное число в массиве.
// int[] mas = new int[8];
// for (int i = 0; i < mas.Length; i++)
// {
//     mas[i] = new Random().Next(0, 10);
// }
// Console.Write("введи число: ");
// int find = int.Parse(Console.ReadLine());
// txt(mas);

// bool num = false;
// for (int i = 0; i < mas.Length; i++)
// {
//     if (find == mas[i]) num = true;
// }
// if (num) Console.WriteLine($"Заданное число {find}, есть в массиве.");
// else Console.WriteLine($"Числа {find} нет в массиве.");

// //Задайте одномерный массив из 123 случайных чисел.
// //Найдите количество элементов массива, значения которых лежат в
// //отрезке [10,99]

// int[] mas = new int[123];
// for (int i = 0; i < mas.Length; i++)
// {
//     mas[i] = new Random().Next(-100, 200);
// }
// txt(mas);
// int count = 0;
// for (int i = 0; i < mas.Length; i++)
// {
//     if (mas[i] >= 10 & mas[i] <= 99)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"В заданном массие числа от 10 до 99 встречаются '{count}' раз");

// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве

int[] mas = new int[5];
int[] rez = new int[(mas.Length+1)/2];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = new Random().Next(0, 30);
}
txt(mas);
void Rez(int[] mas, int[] rez)
{
    rez[rez.Length - 1] = mas[mas.Length / 2];  //для нечетных массивов-оставляет среднее число
    for (int i = 0; i < mas.Length / 2; i++)
    {
        rez[i] = mas[i] * mas[mas.Length - 1 - i];  //mas.Length - 1 - последняя позиция в массиве
    }
}
Rez(mas,rez);
txt(rez);