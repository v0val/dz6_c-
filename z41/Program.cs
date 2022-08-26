Console.WriteLine("Введите количество вводимых чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int Count = 0;
double chislo = 0;
for (int i = 1; i <= M; i++)
{
    chislo = Convert.ToInt32(Console.ReadLine());
    if (chislo > 0) Count ++;
}
Console.Write(" количество  чисел  больше 0 = ");
Console.WriteLine(Count);