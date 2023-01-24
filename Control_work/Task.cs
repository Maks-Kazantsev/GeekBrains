// Программа, которая из имеющегося массива строк, формирует массив из строк, длинна которых меньше, 
//либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
Console.Clear();

int n = 3;
int size = 6;
string[] arrayOne = new string[size];
Console.WriteLine($"Введите набор символов, означающих значение строкового элемента массива, {size} раз через энтер, без пробелов");
FillArray(arrayOne);
// FillArrayRandomly(arrayOne); вариант заполнения массива рандомно
Console.Clear();
// PrintArray(arrayOne);
Console.WriteLine();
Console.WriteLine($"Новый массив, содержащий элементы, размер которых меньше либо равен {n}:");
if (GetSizeOfSecondArray(arrayOne) == 0) { Console.WriteLine("искомых элементов строкового масива для переноса в новый массив - нет"); }
else
{
	string[] arrayTwo = TransferElements(arrayOne);
	// PrintArray(arrayTwo);
	Console.WriteLine($"[{String.Join(", ", arrayOne)}] -> [{String.Join(", ", arrayTwo)}]");
}


void FillArrayRandomly(string[] arr)
{
	Random rand = new Random();
	string AlmostAllSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*";
	for (int i = 0; i < size; i++)
	{
		int randElemSize = rand.Next(1, 7);
		for (int j = 0; j < randElemSize; j++)
		{
			arr[i] += AlmostAllSymbols[rand.Next(0, AlmostAllSymbols.Length)];
		}
	}
}

void FillArray(string[] arr)
{
	for (int i = 0; i < size; i++)
	{
		arr[i] = Console.ReadLine() ?? "";
	}
}

void PrintArray(string[] arr)
{
	int arrLeng = arr.Length;
	Console.Write("[ ");
	for (int i = 0; i < arrLeng; i++)
	{
		Console.Write(arr[i] + " ");
	}
	Console.Write("]");
}

int GetSizeOfSecondArray(string[] arr)
{
	int secondSize = 0;
	for (int i = 0; i < size; i++)
	{
		if (arr[i].Length <= n)
		{
			secondSize++;
		}
	}
	return secondSize;
}

string[] TransferElements(string[] arr)
{
	string[] arrayTwo = new string[GetSizeOfSecondArray(arrayOne)];
	for (int i = 0, j = 0; i < size; i++)
	{
		if (arr[i].Length <= n)
		{
			arrayTwo[j] = arr[i];
			j++;
		}
	}
	return arrayTwo;
}