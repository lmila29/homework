Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (max > b) max = a;
if (max > c) max = a;
if (max < b) max = b;
if (max < c) max = c;

Console.Write("max=");
Console.WriteLine(max);

