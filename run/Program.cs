int b,c;
double a;
Console.WriteLine("Введи первое число - ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введи второе число - ");
b = Convert.ToInt32(Console.ReadLine());
c=1;

while (a<b)
{
    a=a*1.15;
    c++;
}
Console.WriteLine(c);