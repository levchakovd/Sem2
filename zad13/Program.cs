int a;
Console.WriteLine("Введите число, я скажу какая третья цифра ");
a = Convert.ToInt32(Console.ReadLine());
if (a>99)
    Console.Write(Convert.ToString(a)[2]);
else
    Console.WriteLine("третьей цифры нет");