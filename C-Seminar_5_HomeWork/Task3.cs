Console.Clear();
int[] array = CreateRandomArray();
long diff = MaxMinDiff(array);
Console.WriteLine($"Разницу между максимальным и минимальным элементов массива: {diff}");

int[] CreateRandomArray()
{
	Random rnd = new Random();
	int size = rnd.Next(1);
	int[] array = new int[size];
	for (int i = 0; i < size; i++)
	{
		array[i] = rnd.Next();
	}
	return array;
}

int MaxMinDiff(int[] array)
{
	int min = array[0];
	int max = array[0];
	foreach (int i in array)
	{
		if (i < min)
		{
			min = i;
		}
		else if (i > max)
		{
			max = i;
		}
	}
	return max - min;
}