// Найти третью цифру числа или сообщить что ее нет 


Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine());

int n3 = (Number % 1000) / 100;

if (Number > 99)
{
    Console.WriteLine("Третья цифра числа с конца: " + n3);
}
else if (Number < 100)
{
Console.WriteLine("Третьей цифры числа нет");
}
