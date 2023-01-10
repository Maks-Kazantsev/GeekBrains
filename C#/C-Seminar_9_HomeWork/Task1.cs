Console.Clear();
Console.WriteLine("Введите число N: ");
uint n = uint.Parse(Console.ReadLine()!);

PrintNaturalNumbersRecursively(n);

void PrintNaturalNumbersRecursively(uint n)
{
	Console.Write(n);
	if (n > 1)
	{
		Console.Write(", ");
		PrintNaturalNumbersRecursively(n - 1);
	}
}