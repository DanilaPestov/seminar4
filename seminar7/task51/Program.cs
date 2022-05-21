int m = 4, n = 4, sum = 0;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(-10, 10);
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

int size = mass.GetLength(0);//задали условие, чтобы не проверять его в else
if (mass.GetLength(1) < mass.GetLength(0))
{
    size = mass.GetLength(1);
}

for (int i = 0; i < size; i++)
{
    sum = sum + mass[i, i];
}
Console.WriteLine($"Сумма элементов с равными индексами = {sum}");