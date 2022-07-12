//Вывести на экран последнюю цифру целого числа введенного с клавиатуры.
int a;
System.Console.WriteLine("Введите число");
a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(a%10);