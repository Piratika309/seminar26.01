// Выяснить, кратно ли число заданному, если нет, вывести остаток

Console.WriteLine("Введите первое число, на кратность которого будет проверяться второе число: ");
int Number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число, кратность которому будет проверяться первое число: ");
int Number2 = int.Parse(Console.ReadLine());

if (Number2 % Number1 == 0)
{
     Console.WriteLine("Второе число " + Number2 + " кратно первому " + Number1);
}
else
{
    Console.WriteLine("Второе число " + Number2 + " не кратно первому " + Number1);
    Console.WriteLine("Остаток равен: " + (Number2 % Number1));
}