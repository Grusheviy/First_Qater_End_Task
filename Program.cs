



string[] arrayOfStrings = new string[]  {};
int lengthMax = 3;
Console.WriteLine("Write your array length number: ");
int n = Convert.ToInt32(Console.ReadLine());
arrayOfStrings = new string[n];
for (int i = 0; i < arrayOfStrings.Length; i++)
  {
    Console.Write($" Write {i+1} string: ");
    arrayOfStrings[i] = Console.ReadLine();
  }