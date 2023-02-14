







int ArrayCheck(string[] array, int lengthMax)
{
  int result = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= lengthMax) result++;
  }
  return result;
}
Console.WriteLine("Write your array length number: ");
int n = Convert.ToInt32(Console.ReadLine());
String[] ArrayOfStrings = new string[n];
int lengthMax = 3;
for (int i = 0; i < ArrayOfStrings.Length; i++)
  {
    Console.Write($" Write {i+1} string: ");
    ArrayOfStrings[i] = Console.ReadLine();
  }
int NumbesOfStrings = ArrayCheck(ArrayOfStrings, lengthMax);
// Console.WriteLine($"{NumbesOfStrings}");