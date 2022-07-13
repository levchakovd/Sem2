int a;
Console.WriteLine("Введи трехзначное число - ");
a = Convert.ToInt32(Console.ReadLine());

if (a>=100 && a<=999)
{
        int result = (a/10%10);
        Console.WriteLine(result);
}
else
{
        Console.WriteLine("Внимательнее! ТРЕХЗНАЧНОЕ число! ");
    
}
