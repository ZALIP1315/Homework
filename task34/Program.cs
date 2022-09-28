// task34
int[] GetArray(int size,int leftRange,int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0;i<size;i++)
    {
        arr[i]=rand.Next(leftRange,rightRange + 1);
    }
    return arr;
}

int[ ] array = GetArray(4,100,999);
Console.WriteLine(string.Join(", ",array));
int count = 0;
for(int i=0;i<array.Length;i++)
{
    if (array [i] == (array [i]/2)*2)
      {
        count++;
    }
}
Console.WriteLine($"количество чётных чисел в массиве = {count}");