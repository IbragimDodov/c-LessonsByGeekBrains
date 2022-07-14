string? inputLine = Console.ReadLine();

if (inputLine != null)
{
  int inputNumber = int.Parse(inputLine);

  string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputNumber));
  Console.WriteLine(outDayOfWeek);

  // string[] dayOfWeek = new string[7];
  // dayOfWeek[0] = "Monday";
  // dayOfWeek[1] = "Tuesday";
  // dayOfWeek[2] = "Wednesday";
  // dayOfWeek[3] = "Thursday";
  // dayOfWeek[4] = "Friday";
  // dayOfWeek[5] = "Saturday";
  // dayOfWeek[6] = "Sunday";

  // Console.WriteLine(dayOfWeek[inputNumber - 1]);
}
