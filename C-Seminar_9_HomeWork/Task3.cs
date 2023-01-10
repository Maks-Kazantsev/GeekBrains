Console.Clear();
Console.WriteLine("Введите число m: ");
uint m = uint.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число n: ");
uint n = uint.Parse(Console.ReadLine()!);

Console.WriteLine($"A({m},{n}) = {A(m, n)}");

static uint A(uint m, uint n)
{
	if (m == 0)
		return n + 1;
	else
	  if ((m != 0) && (n == 0))
		return A(m - 1, 1);
	else
		return A(m - 1, A(m, n - 1));
}