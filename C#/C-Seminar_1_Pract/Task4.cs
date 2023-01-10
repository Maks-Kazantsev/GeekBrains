//Программа, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке 
//от -N до N 4->"-4,-3,-2,-1,,0,1,2,3,4"
//2-"-2,-1,0,1,2"
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
for (int i = number * (-1); i < number + 1; i++)
{
	Console.Write(i + $" ");
}
