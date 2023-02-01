// По заданному номеру дня недели вывести его название


Console.WriteLine("Введите необходимый день недели: ");

int N = int.Parse(Console.ReadLine());

if (N == 1)
{
    Console.WriteLine("День недели под номером " + N + " : Понедельник");
}
else if (N == 2)
{
    Console.WriteLine("День недели под номером " + N + " : Вторник");
}
else if (N == 3)
{
    Console.WriteLine("День недели под номером " + N + " : Среда");
}
else if (N == 4)
{
    Console.WriteLine("День недели под номером " + N + " : Четверг");
}
else if (N == 5)
{
    Console.WriteLine("День недели под номером " + N + " : Пятница");
}
else if (N == 6)
{
    Console.WriteLine("День недели под номером " + N + " : Суббота");
}
else if (N == 7)
{
    Console.WriteLine("День недели под номером " + N + " : Воскресенье");
}
else
{
     Console.WriteLine("Неправильно введен номер дня");
}
