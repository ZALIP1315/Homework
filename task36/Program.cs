// task36
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


int[ ] array = GetArray(4,-999,999);
Console.WriteLine(string.Join(", ",array));
int sum = 0;
for( int i= 1;i<array.Length;i+=2)
{
    sum=sum + array[i];
}
Console.WriteLine ($"сумма элементов, стоящих на нечётных позициях = {sum}");