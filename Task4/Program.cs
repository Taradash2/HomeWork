Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;
int i = n * (0);
while (i <= n && i >= m)
{
    Console.Write($"{i} ");
    i++;
}