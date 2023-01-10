Console.Clear();
Console.WriteLine("Введите цифру:");
string input = Console.ReadLine();
int number = int.Parse(input);
if (number > 7 || number < 1)
{
	Console.WriteLine("Не является днем недели");
}
else
{
	if (number < 6)
	{
		Console.WriteLine("Будний");
	}
	else
	{
		Console.WriteLine("Выходной");
	}
}