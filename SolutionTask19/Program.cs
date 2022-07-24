int P = int.Parse(Console.ReadLine());

int d1 = P / 10000;
int d2 = (P / 1000) % 10;
int d3 = (P / 100) % 10;
int d4 = (P / 10) % 10;
int d5 = P % 10;

if (d1 == d5 && d2 == d4)
{
  Console.WriteLine("this number is palindrom");
}
else
{
  Console.WriteLine("this number is not a palindrom");
}
