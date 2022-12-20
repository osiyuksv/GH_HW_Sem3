// Вывести расстояние между двумя точками в 2D
// пространстве по принятым координатам 2х точек
Console.WriteLine("Введите x для точки 1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y для точки 1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x для точки 2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x для точки 2");
int y2 = Convert.ToInt32(Console.ReadLine());

double n = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2));

Console.WriteLine(n);
