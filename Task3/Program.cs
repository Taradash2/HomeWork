Console.Clear();
Console.WriteLine("Напишите четное число");
int n = Convert.ToInt32(Console.ReadLine());
 
while (n % 2 != 0)
{
     Console.WriteLine("Неправильно!\nВведите четное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}
    Console.WriteLine("Правильно!");
    
