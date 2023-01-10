Console.Clear();

Console.WriteLine("Введите координату X точки A:");
double xA = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y точки A:");
double yA = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z точки A:");
double zA = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату X точки B:");
double xB = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y точки B:");
double yB = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z точки B:");
double zB = double.Parse(Console.ReadLine()!);

double d = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));

Console.WriteLine($"Расстояние между точками: {d.ToString("#.00")}");
