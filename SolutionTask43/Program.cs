int valueB1; //введение глобальных переменных
int valueK1;
int valueB2;
int valueK2;
int coordyX = 0;
int coordyY = 0;
string coordy;


void ReadingFunctionValues()
{
  Console.WriteLine("Введите значение b1");
  valueB1 = int.Parse(Console.ReadLine() ?? "");

  Console.WriteLine("Введите значение k1");
  valueK1 = int.Parse(Console.ReadLine() ?? "");

  Console.WriteLine("Введите значение b2");
  valueB2 = int.Parse(Console.ReadLine() ?? "");

  Console.WriteLine("Введите значение k2");
  valueK2 = int.Parse(Console.ReadLine() ?? "");
}

void Conculate() //метод подсчета координат точки пересечения
{
  if ((valueK1 == valueK2) && (valueB1 == valueB2))

    Console.WriteLine("Прямые совпадают"); //проверка на совпадение прямых
  else
      if (valueK1 == valueK2)
    Console.WriteLine("Прямые параллельны"); //проверка на параллельность прямых       
  else
  {
    coordyX = (valueB2 - valueB1) / (valueK1 - valueK2); //применение расчетов
    coordyY = (valueK1 * (valueB2 - valueB1)) / (valueK1 - valueK2) + valueB1;
  }
  coordy = "Координаты точки пересечения: " + coordyX + "," + coordyY;
}

void PrintPointOfIntersectionOfCoordinates() //метод вывода ответа
{
  Console.WriteLine(coordy);
}

ReadingFunctionValues();
Conculate();
PrintPointOfIntersectionOfCoordinates();