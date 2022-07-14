int a,b,c,y;
Console.WriteLine("Ваша стартовая сумма - ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Желаемая сумма - ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Процент годовых- ");
c = Convert.ToInt32(Console.ReadLine());
y=1;
//double preresult = 1+c/100;
//double pre = (b/a);
//double result=Math.Log(pre,preresult);

while (a<b)
    c=c/100;
    a=a*(1+c);
    y++;

Console.WriteLine("нужная сумма получится через" + y + "лет");
