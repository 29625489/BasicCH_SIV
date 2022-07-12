//Выяснить является ли число чётным.
int a;
System.Console.WriteLine("Введите число");
a = Convert.ToInt32(Console.ReadLine());
if(a % 2 == 0)
{
    Console.WriteLine("число целое");
}
else
{
    Console.WriteLine("число не целое");
}