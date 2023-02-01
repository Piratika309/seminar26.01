// Показать все четные числа от 1 до N

int number1 = 0;
int number2 = (number1 + 2);

Console.WriteLine(" Введите число  N, до которого будет выполняться вывод четных чисел : ");

int N =  int.Parse(Console.ReadLine());

while (number2 <= N && number2 %2 == 0)

{
    Console.WriteLine(number2);
    number2 = (number2 + 2);
}

