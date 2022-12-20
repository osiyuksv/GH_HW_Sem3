// вывести сумму квадратов для
// числа N от 1 до N
Console.WriteLine("Введите число N>0");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
int SumSq = 0;

while(count <= n)
{
  SumSq = SumSq + count * count;
  count++;
}Console.WriteLine(SumSq);
