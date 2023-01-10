Console.Clear();
Console.WriteLine("Введите число:");
string input = Console.ReadLine();
int n = int.Parse(input);
for(int i = 1; i <= n; i++) {
    Console.Write(Math.Pow(i, 3));
    if(i < n) {
        Console.Write(", ");
    }
}
