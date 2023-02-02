// Дано число из отрезка [10,99]. Показать наибольшее цифру числа

int N = new Random().Next(10,99);
Console.WriteLine("Дано число " + N);

int a = (N/10);
int b = (N - a*10);

if (a>b)
{
    Console.WriteLine("Максимальная цифра числа : " + a);
}
if (a<b)
{
Console.WriteLine("Максимальная цифра числа: " + b);
}
