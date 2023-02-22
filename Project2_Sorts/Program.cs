// Bubble sort (пузырбковая сортировка)

int k=0;

int [] Array1 = RandomIntArray(5,1,9);
PrintArray(Array1);
System.Console.WriteLine();
SelectSort(Array1);
PrintArray(Array1);
System.Console.WriteLine();
// System.Console.WriteLine(k);


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

int BubbleSort (int [] array)
{
    for (int j =0; j<array.Length; j++) // повторяем цикл столько раз, сколько элементов в массиве 
      for (int i =0; i<array.Length-1-j; i++) // вычитаем 1 чтобы последний элемент ни с чем не сравнивать
  {
    if (array[i]>array[i+1])
    {
      k = k+1;
      int t = array[i];
      array[i]=array[i+1];
      array[i+1] = t;
    }
  }
  return k; // добавили счетчик кол-ва проведенных перестановок
}

void SelectSort (int [] array)
{
  for (int j =0; j<array.Length; j++)
  {
    int indMin = j;
    for (int i =j+1; i<array.Length; i++)
    {
      if (array[i]<array[indMin])
      {
        indMin = i;
      }
    }
      int t = array[j];
      array [j] = array[indMin];
      array[indMin] = t;
  }
}