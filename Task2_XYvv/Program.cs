// Вывести по номеру четверти плоскости диапазон
// возможных кординат точек в ней

Console.WriteLine("Введите номер плоскости");
int n = Convert.ToInt32(Console.ReadLine());

switch(n)
{
  case 1:
  {
    Console.WriteLine("Возможный диапазон кординат точек: (x>0;y>0)");
    break;
  }
    case 2:
  {
    Console.WriteLine("Возможный диапазон кординат точек: (x<0;y>0)");
    break;
  }
    case 3:
  {
    Console.WriteLine("Возможный диапазон кординат точек: (x<0;y<0)");
    break;
  }
    case 4:
  {
    Console.WriteLine("Возможный диапазон кординат точек: (x>0;y<0)");
    break;
  }
      default:
  {
    Console.WriteLine("Некорректный номер плоскости");
    break;
  }
}


