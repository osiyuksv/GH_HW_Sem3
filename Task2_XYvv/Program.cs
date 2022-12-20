// Вывести по номеру четверти плоскости диапазон
// возможных кординат точек в ней

Console.WriteLine("Введите номер плоскости");
int n = Convert.ToInt32(Console.ReadLine());

if(n == 1) 
Console.WriteLine("Возможный диапазон кординат точек: (x>0;y>0)");
if(n == 2) 
Console.WriteLine("Возможный диапазон кординат точек: (x<0;y>0)");
if(n == 3) 
Console.WriteLine("Возможный диапазон кординат точек: (x<0;y<0)");
if(n == 4) 
Console.WriteLine("Возможный диапазон кординат точек: (x>0;y<0)");

