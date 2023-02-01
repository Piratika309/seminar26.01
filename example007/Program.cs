// Показать вторую цифру трехзначного числа


Console.WriteLine("Введите трехзначное число: ");
int Number = int.Parse(Console.ReadLine());

int n1 = (Number/100);
int n2 = (Number/10) - 10 * n1;

Console.WriteLine("Вторая цифра введенного трехзначного числа :  " + n2); 
