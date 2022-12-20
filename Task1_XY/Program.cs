// Вывести номер четверти плоскости в которой находится 
// точка с координатами X и Y при этом X и Y не = 0
Console.WriteLine("Введите координату X");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y");
int y = Convert.ToInt32(Console.ReadLine());

if((x == 0) && (y == 0)) 
{
  Console.WriteLine("Введена точка с нулевыми координатами");
}
else
{
if((x >= 0) && (y >= 0)) Console.WriteLine(1);
if((x <= 0) && (y >= 0)) Console.WriteLine(2);
if((x <= 0) && (y <= 0)) Console.WriteLine(3);
if((x >= 0) && (y <= 0)) Console.WriteLine(4);
}