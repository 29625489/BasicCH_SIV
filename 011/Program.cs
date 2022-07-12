//Дано число больше 9. Вывести на экран  вторую цифру числа с конца
int a,b;
System.Console.WriteLine("Введите число");
a = new Random().Next(9,99);
System.Console.WriteLine(a);
b = a/10;
System.Console.WriteLine("второй знак с конца");
System.Console.WriteLine(b);