int p = 1;
int Proisv(int n)
{
    if (n == 1) return p;
    Proisv(n-1);
    p *= n;
    return p;
}
Console.WriteLine("Введите целое число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"произведение целых чисел от 1 до {n}: ");
Console.WriteLine(Proisv(n));