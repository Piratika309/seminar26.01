// Показать последнюю цифру трехзначного числа


Console.WriteLine("Введите трехзначное число: ");
int Number = int.Parse(Console.ReadLine());

int n1 = (Number/100);
int n2 = (Number/10) - 10 * n1;
int n3 = (Number-(n1*100)-(n2*10));

Console.WriteLine("Последняя цифра введенного трехзначного числа :  " + n3); 
