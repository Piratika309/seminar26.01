// Выяснить является ли число четным

Console.WriteLine(" Введите число : ");
int Number = int.Parse(Console.ReadLine());

if(Number % 2 == 0)
{
Console.WriteLine("Введенное Вами число " + Number + " является четным ");
}
else
{
Console.WriteLine(" Введенное Вами число " + Number + " является нечетным ");
}

