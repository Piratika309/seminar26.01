// Удалить вторую цифру трехзначного числа

Console.WriteLine("Введите трехзначное число: ");
int Number = int.Parse(Console.ReadLine());

int n1 = (Number/100);
int n2 = (Number/10) - 10 * n1;
int n3 = (Number-(n1*100)-(n2*10));

int N = (10*n1 +n3);

Console.WriteLine("Получившееся число  после удаления  второй цифры:  " + N); 