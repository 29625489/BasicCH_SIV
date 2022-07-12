//С клавиатуры вводятся три числа. Найти максимальное из трех чисел
int a, b, c;
System.Console.WriteLine("Введите  числа");
a=Convert.ToInt32(Console.ReadLine());
b=Convert.ToInt32(Console.ReadLine());
c=Convert.ToInt32(Console.ReadLine());
int max = a;
    if (a > max) max = a;
    if (b > max) max = b;
    if (c > max) max = c;
   System.Console.Write("max = ");
   System.Console.WriteLine(max);
    