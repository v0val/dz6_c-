Console.WriteLine("Hello, World!");
int[] mas = new int[10];
int[] mas2 = new int[10];
for (int i = 0; i < 10; i++)
{
    mas[i] = new Random().Next(-10, 10);
}
for (int i = 0; i < 10; i++)
{
    mas2[i] = mas[i];
}
//mas2 = mas;
var str = string.Join(" ", mas2);
Console.WriteLine(str);