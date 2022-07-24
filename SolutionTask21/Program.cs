int coordXPointA;
int coordYPointA;
int coordZPointA;

int coordXPointB;
int coordYPointB;
int coordZPointB;

double lengthAB;

// считывает координаты точек А и В
void readDataOfPoint()
{
  Console.WriteLine("Введите координату X точки A");
  coordXPointA = int.Parse(Console.ReadLine());

  Console.WriteLine("Введите координату Y точки A");
  coordYPointA = int.Parse(Console.ReadLine());

  Console.WriteLine("Введите координату Z точки A");
  coordZPointA = int.Parse(Console.ReadLine());


  Console.WriteLine("Введите координату X точки B");
  coordXPointB = int.Parse(Console.ReadLine());

  Console.WriteLine("Введите координату Y точки B");
  coordYPointB = int.Parse(Console.ReadLine());

  Console.WriteLine("Введите координату Z точки B");
  coordZPointB = int.Parse(Console.ReadLine());
}

// Вычисляет состояние между точками А и В
void conculateLengthAB()
{
  lengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordYPointA - coordYPointB), 2) + Math.Pow((coordZPointA - coordZPointB), 2));
}

readDataOfPoint();
conculateLengthAB();

Console.WriteLine(lengthAB);
