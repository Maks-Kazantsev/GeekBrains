Console.WriteLine("Задайте размеры массива");
Console.Write("m = ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("n = ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = CreateRandom2DArray(m, n);

double[] columnsAverage = Calc2DArrayColumnsAverage(array);
Console.WriteLine("Cреднее арифметическое элементов в столбцах:");
for (int i = 0; i < n; i++)
{
	Console.Write(columnsAverage[i]);
	if (i < n - 1)
	{
		Console.Write("; ");
	}
}

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

double[] Calc2DArrayColumnsAverage(int[,] array)
{
	int[] sizes = Get2DArraySizes(array);
	int rowsCont = sizes[0];
	int columnsCont = sizes[1];
	double[] columnsAverage = new double[columnsCont];
	for (int j = 0; j < columnsCont; j++)
	{
		long sum = 0;
		for (int i = 0; i < rowsCont; i++)
		{
			sum += array[i, j];
		}
		columnsAverage[j] = (double)sum / rowsCont;
	}
	return columnsAverage;
}