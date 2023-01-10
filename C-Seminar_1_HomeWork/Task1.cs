Console.Clear();

Console.Write("Введите число a: ");
string inputA = Console.ReadLine();
int a = int.Parse(inputA);

Console.Write("Введите число b: ");
string inputB = Console.ReadLine();
int b = int.Parse(inputB);

if (a > b)
{
	Console.WriteLine($"max = {a} min = {b}");
}
else
{
	Console.WriteLine($"max = {b} min = {a}");
}