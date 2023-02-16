







int ArrayCheck(string[] array, int lengthMax)
{
  int result = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= lengthMax) result++;
  }
  return result;
}
void FillArray(string[] FirstArray, string[] ResultArray, int lengthMax)
{
  int temp = 0;
  for (int i = 0; i < FirstArray.Length; i++)
  {
    if (FirstArray[i].Length <= lengthMax)
    {
      ResultArray[temp] = FirstArray[i];
      temp++;
    }
  }
}
void PrintArray(string[] array)
{ 
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
    {
      Console.Write('"' + array[i] +'"');
        if (i < array.Length - 1)
        {
          Console.Write(",");
        }
    }
  Console.Write("]");
}

Console.WriteLine("Write your array length number: ");
int n = Convert.ToInt32(Console.ReadLine());
String[] ArrayOfStrings = new string[n];
int lengthMax = 3;

// Console.WriteLine("Write your result array symbol length: ");
// int lengthMax = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < ArrayOfStrings.Length; i++)
  {
    Console.Write($" Write {i+1} string: ");
    ArrayOfStrings[i] = Console.ReadLine();
  }
int NumbesOfStrings = ArrayCheck(ArrayOfStrings, lengthMax);
// Console.WriteLine($"{NumbesOfStrings}");
string[] ResultArrayOfStrings = new string[NumbesOfStrings];
FillArray(ArrayOfStrings, ResultArrayOfStrings, lengthMax);
PrintArray(ResultArrayOfStrings);