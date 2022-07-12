//С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго 
double a,b;
System.Console.WriteLine("Введите два числа");
string? s = Console.ReadLine();
a = Convert.ToDouble(s);
s = Console.ReadLine();
b = Convert.ToDouble(s);

if (a*a==b)
{
Console.WriteLine("b квадрат a");
}
else 
{
Console.WriteLine("b не квадрат a");
}
if (b*b==a)
{
    Console.WriteLine("a квадрат b");
}
else
{
    Console.WriteLine("a не квадрат b");
}
