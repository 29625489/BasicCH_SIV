//Написать программу вычисления значения функции y = sin(a). (Класс Math)
double a,y;
System.Console.WriteLine("Введите число");
a = Convert.ToDouble(Console.ReadLine());
y = (a* (Math.PI)) / 180;                     
System.Console.WriteLine(Math.Sin(y));  



