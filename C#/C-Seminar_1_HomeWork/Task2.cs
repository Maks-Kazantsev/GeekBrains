Console.Clear();

Console.Write("Введите число a: ");
string inputA = Console.ReadLine();
int a = int.Parse(inputA);

Console.Write("Введите число b: ");
string inputB = Console.ReadLine();
int b = int.Parse(inputB);

Console.Write("Введите число c: ");
string inputC = Console.ReadLine();
int c = int.Parse(inputC);

if (a > b && a > c)
{
	Console.WriteLine($"max = {a}");
}
else if (b > a && b > c)
{
	Console.WriteLine($"max = {b}");
}
else if (c > a && c > b)
{
	Console.WriteLine($"max = {c}");
}