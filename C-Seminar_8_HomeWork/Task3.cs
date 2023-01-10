Console.Clear();
Console.WriteLine("Задайте размеры первой матрицы");
Console.Write("m = ");
int m1 = int.Parse(Console.ReadLine()!);

Console.Write("n = ");
int n1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Задайте размеры первой матрицы");
Console.Write("m = ");
int m2 = int.Parse(Console.ReadLine()!);

Console.Write("n = ");
int n2 = int.Parse(Console.ReadLine()!);

if (n1 != m2)
{
	Console.WriteLine("Произведение матриц невозможно");
}
else
{
	int[,] matrix1 = CreateRandom2DArray(m1, n1);
	int[,] matrix2 = CreateRandom2DArray(m2, n2);
	Print2DArray(MultiplyMatrix(matrix1, matrix2));
}

int[,] CreateRandom2DArray(int m, int n)
{
	Random rnd = new Random();
	int[,] array = new int[m, n];
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
			array[i, j] = rnd.Next(0, 10);
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

int[,] MultiplyMatrix(int[,] martrix1, int[,] martrix2)
{
	int[] sizesMartrix1 = Get2DArraySizes(martrix1);
	int[] sizesMartrix2 = Get2DArraySizes(martrix2);
	int[,] result = new int[sizesMartrix1[0], sizesMartrix2[1]];
	for (int i = 0; i < sizesMartrix1[0]; i++)
	{
		for (int j = 0; j < sizesMartrix2[1]; j++)
		{
			int sum = 0;
			for (int k = 0; k < sizesMartrix1[1]; k++)
			{
				sum += martrix1[i, k] * martrix2[k, j];
			}
			result[i, j] = sum;
		}
	}
	return result;
}