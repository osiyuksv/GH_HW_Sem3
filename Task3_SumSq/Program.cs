// вывести сумму квадратов для
// числа N от 1 до N
Console.WriteLine("Введите число N>0");
int n = Convert.ToInt32(Console.ReadLine());
int SumSq = 0;

Console.WriteLine("Сумма квадратов равна " + SumSq);

for(int i = 1; i <= n; i++)
{
  SumSq = SumSq + i * i;
  Console.Write(i * i + "; "); 
}
Console.WriteLine("Сумма квадратов равна " + SumSq);

// while(count <= n)
// {
// SumSq = SumSq + count * count;
// Console.Write(count * count + "; ");
//count++;
// }