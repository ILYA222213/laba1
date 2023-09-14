int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int result = 0;
int sign1 = Math.Sign(a);
int singn2 = Math.Sign(b);

a = Math.Abs(a);
b = Math.Abs(b);
for (var i = 0; i < a; i++) result += b;
if (sign1 == singn2)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine(-result);
}