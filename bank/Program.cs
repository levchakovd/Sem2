double a,b,c;
Console.WriteLine("Ваша стартовая сумма - ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Желаемая сумма - ");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Процент годовых- ");
c = Convert.ToDouble(Console.ReadLine());

double preresult,pre;
preresult = 1+c/100;
pre = (b/a);
int result=Convert.ToInt32(Math.Log(pre,preresult));

Console.WriteLine(result);
