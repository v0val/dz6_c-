Console.WriteLine("Введите количество чисел Фибоначи ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ряд чисел Фибоначи ");
int x1 = 0;
int x2 = 1;
int summ = 0;
Console.Write("0 1 ");
for (int i = 1; i < n-1; i++)
{
    summ = x1+x2;
    Console.Write($"{summ} ");
    x1 = x2;
    x2 = summ;
}