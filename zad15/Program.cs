int n;
n = Convert.ToInt32(Console.ReadLine());
if (n >= 1 && n <= 7)
{
    if (n <=5)
        Console.WriteLine("нет");
    if (n >5)
        Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет такого дня недели");
}
