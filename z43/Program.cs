Console.WriteLine("введите целые коэффициенты 1-го уравнения");
int k1 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите коэффициенты 2-го уравнения");
int k2 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
if (k1 == k2 && b1 != b2) Console.WriteLine("прямые параллельны, решения нет");
if (k1 == k2 && b1 == b2) Console.WriteLine("прямые совпали, решением является вся числовая прямая");
if (k1 != k2) 
{
    double x = (b2 - b1) / (k1 - k2); 
    double y = k1 * x + b1;
    Console.WriteLine($"точка пересечения прямых ({x}; {y})");
}