int coordXPointA;
int coordYPointA;
int coordXPointB;
int coordYPointB;

double lengthAB;

// считывает координаты точек А и В
void readDataOfPoint()
{
  Console.WriteLine("Введите координату X точки A");
  coordXPointA = int.Parse(Console.ReadLine());

  Console.WriteLine("Введите координату Y точки A");
  coordYPointA = int.Parse(Console.ReadLine());

  Console.WriteLine("Введите координату X точки B");
  coordXPointB = int.Parse(Console.ReadLine());

  Console.WriteLine("Введите координату Y точки B");
  coordYPointB = int.Parse(Console.ReadLine());
}

// Вычисляет состояние между точками А и В
void conculateLengthAB()
{
  lengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordYPointA - coordYPointB), 2));
}

readDataOfPoint();
conculateLengthAB();

Console.WriteLine(lengthAB);