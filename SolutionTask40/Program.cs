// int sideA = 0;
// int sideB = 0;
// int sideC = 0;

// ReadSides();
// bool res = TestTriangle(sideA,sideB,sideC);
// PrintAnswer(res);

// void ReadSides()
// {
// Console.WriteLine("Введите число 1: ");
// int sideA = int.Parse(Console.ReadLine() ?? "");
// Console.WriteLine("Введите число 2: ");
// int sideB = int.Parse(Console.ReadLine() ?? "");
// Console.WriteLine("Введите число 3: ");
// int sideC = int.Parse(Console.ReadLine() ?? "");
// }

// bool TestTriangle(int sideA, int sideB, int sideC)
// {   //переменная   (              условие      )       (значение1)(значение2)
//     bool answer = ((sideA+sideB>sideC)&&(sideB+sideC>sideA)&&(sideA+sideC>sideB)) ? true : false;
//     return answer;
// }

// void PrintAnswer(bool answer)
// {
//     if (answer)
//     {
//         Console.WriteLine("Из этих отрезков можно составить треугольник");
//     }
//     else
//     {
//         Console.WriteLine("Из этих отрезков нельзя составить треугольник");
//     }
// }

//проверка существования треугольника
bool CheckTriangle(int[] numbers)
{
  if ((numbers[0] + numbers[1] > numbers[2])
  && (numbers[2] + numbers[0] > numbers[1])
  && (numbers[1] + numbers[2] > numbers[0]))
    return true;
  else
    return false;
}
Console.Clear();

Console.WriteLine("Выведите три числа в формате Ч1 Ч2 Ч3");
try
{
  string[] stringNumbers = Console.ReadLine().Split(" ");
  int[] numbers = new int[3];
  for (int i = 0; i < stringNumbers.Length; i++)
    numbers[i] = int.Parse(stringNumbers[i]);
  if (CheckTriangle(numbers))
    Console.WriteLine("Треугольник существует");
  else
    Console.WriteLine("Треугольник не существует");
}
catch
{
  Console.WriteLine("Некорректный формат ввода");
}