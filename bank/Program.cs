int a,b,c;
Console.WriteLine("Ваша стартовая сумма - ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Желаемая сумма - ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Процент годовых- ");
c = Convert.ToInt32(Console.ReadLine());

double preresult,pre;
Convert.ToDouble(preresult = 1+c/100);
Convert.ToDouble(pre = (b/a));
int result=Convert.ToInt32(Math.Log(pre,preresult));

Console.WriteLine(result);
