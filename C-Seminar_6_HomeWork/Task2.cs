Console.Write("k1 = ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("b1 = ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("k2 = ");
double k2 = double.Parse(Console.ReadLine()!);
Console.Write("b2 = ");
double b2 = double.Parse(Console.ReadLine()!);

bool isParallel = CheckLinesParallel(k1, k2);
if (isParallel)
{
	Console.WriteLine("Прямые не пересекаются");
}
else
{
	double[] intersectionPoint = FindIntersectionPoint(k1, b1, k2, b2);
	Console.WriteLine($"Точка пересечения прямых: {string.Join(", ", intersectionPoint)}");
}

bool CheckLinesParallel(double k1, double k2)
{
	return k1 == k2;
}

double[] FindIntersectionPoint(double k1, double b1, double k2, double b2)
{
	double x = (b2 - b1) / (k1 - k2);
	double y = k1 * x + b1;
	return new double[2] { x, y };
}