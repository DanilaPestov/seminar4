int m = 5;
int n = 4;

int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(-10, 10);
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}
