// Найти максимальное из 3 чисел

Console.WriteLine(" Введите первое число : ");
int Number1 = int.Parse(Console.ReadLine());

Console.WriteLine(" Введите второе число : ");
int Number2 = int.Parse(Console.ReadLine());

Console.WriteLine(" Введите третье число : ");
int Number3 = int.Parse(Console.ReadLine());

int max = Number1;
if(Number2>max) max = Number2;
if(Number3>max) max = Number3;

Console.WriteLine(" Максимальное число : " + max);
