Console.Clear();
Console.WriteLine("Задайте размеры массива");
Console.Write("m = ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("n = ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = CreateRandom2DArray(m, n);
Sort2DArrayRowsDesc(array);
Print2DArray(array);

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

int[] Get2DArraySizes(int[,] array)
{
	return new int[2] { array.GetLength(0), array.GetLength(1) };
}

void Print2DArray(int[,] array)
{
	int[] sizes = Get2DArraySizes(array);
	for (int i = 0; i < sizes[0]; i++)
	{
		for (int j = 0; j < sizes[1]; j++)
		{
			Console.Write($"{array[i, j]} ");
		}
		Console.WriteLine("");
	}
}

void Sort2DArrayRowsDesc(int[,] array)
{
	int[] sizes = Get2DArraySizes(array);
	for (int i = 0; i < sizes[0]; i++)
	{
		for (int j = 0; j < sizes[1]; j++)
		{
			for (int k = 0; k < sizes[1] - 1; k++)
			{
				if (array[i, k] < array[i, k + 1])
				{
					int nextElement = array[i, k + 1];
					array[i, k + 1] = array[i, k];
					array[i, k] = nextElement;
				}
			}
		}
	}
}