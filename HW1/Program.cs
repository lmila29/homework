Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = b;

if (a > b) max = a;
if (a > b) min = b;
if (b > a) max = b;
if (b > a) min = a;

Console.Write("max=");
Console.WriteLine(max);
Console.Write("min=");
Console.WriteLine(min);
