//С клавиатуры вводятся два числа a и b. Найти максимальное из них.


int a,b;
Console.WriteLine("Введите числа");
a=Convert.ToInt32(Console.ReadLine());
b=Convert.ToInt32(Console.ReadLine());
    if (a>b) 
    {
        Console.WriteLine("{0} max number",a);
    }
    else
    {
        Console.WriteLine("{0} max number",b);
    }


