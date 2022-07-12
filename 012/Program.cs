//Дано число из  диапозона  [10, 99]. Показать наибольшую цифру числа
int a,b,c,max;
System.Console.WriteLine("Введите число");
a = new Random().Next(10,99);
System.Console.WriteLine(a);
b = a/10;
c = a%10;
max = b;
if (b > c) 
{
    max = b;
}
else
{max = c;

}
System.Console.WriteLine("наибольшее число");
System.Console.WriteLine(max);