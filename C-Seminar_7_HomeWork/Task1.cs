Console.WriteLine("Задайте размеры массива");
Console.Write("m = ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("n = ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = CreateRandom2DArray(m, n);

int[,] CreateRandom2DArray(int m, int n)
{
	Random rnd = new Random();
	int[,] array = new int[m, n];
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
			array[i, j] = rnd.Next();
	}
	return array;
}