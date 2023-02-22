// Изучение бинарного поиска

int [] Array1 = RandomIntArray(5,1,9);
PrintArray(Array1);
System.Console.WriteLine();
Array.Sort(Array1);
PrintArray(Array1);
System.Console.WriteLine();
System.Console.WriteLine($"{BinSearch(Array1,5)}");

int [] RandomIntArray (int N, int min, int max)
{
  int [] array = new int [N];
  Random rndm = new Random();
  for (int i =0; i<array.Length; i++)
  {
    array[i]=rndm.Next(min,max+1);
  }
  return array;
}

void PrintArray (int [] array)
{
    for (int i =0; i<array.Length; i++)
  {
    System.Console.Write($"{array[i],2} ");
  }
}

int BinSearch ( int [] array, int find)
{
  int i;
  int left = 0;
  int right = array.Length-1;
  i = left + (right - left)/2;
  while (array[i]!=find && left<right)
  {
    if (find>array[i])
    {
      left=i+1;
    }
    else
    {
      right=i;
    }
    i = left + (right - left)/2;
  }
  if (array[i]!=find) return -1;
  else return i; // указываем индекс искомого числа
}
