Console.Clear();
Console.WriteLine("Задайте размеры массива:");
Console.Write("m = ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("n = ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("k = ");
int k = int.Parse(Console.ReadLine()!);

int[,,] array = CreateRandom3DArray(m, n, k);
Print3DArrayWithIndexes(array);



int[,,] CreateRandom3DArray(int m, int n, int k)
{
	Random rnd = new Random();
	int[,,] array = new int[m, n, k];
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			for (int z = 0; z < k; z++)
			{
				array[i, j, z] = rnd.Next(0, 10);
			}
		}
	}
	return array;
}

int[] Get3DArraySizes(int[,,] array)
{
	return new int[3] { array.GetLength(0), array.GetLength(1),
array.GetLength(2) };
}

void Print3DArrayWithIndexes(int[,,] array)
{
	int[] sizes = Get3DArraySizes(array);
	for (int i = 0; i < sizes[0]; i++)
	{
		for (int j = 0; j < sizes[1]; j++)
		{

			for (int z = 0; z < sizes[2]; z++)
			{
				Console.Write($"{array[i, j, z]}({i},{j},{z}) ");
			}
			Console.WriteLine("");
		}
	}
}