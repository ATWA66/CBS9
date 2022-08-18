//2
Console.WriteLine("enter the number of elements");
int[] arr = new int[Convert.ToInt32(Console.ReadLine())];
Random rand = new Random();
int min=int.MaxValue, max=int.MinValue, sum=0;
for (int i = 0 ; i < arr.Length; i++)
{
    arr[i] = rand.Next(0,5);
    Console.WriteLine("" + arr[i]);
}
for (int i = 0; i < arr.Length; i++)
{ 
if(arr[i] > max)
        max = arr[i];
if (arr[i] < min)
    min = arr[i];
    sum += arr[i];
    if ((arr[i] & 1) == 1)
        Console.WriteLine("!/2 - {0}", arr[i]);
}
Console.WriteLine("min-{0}\nmax{1}\nsum-{2}\n mid-{3}",min,max,sum, sum/arr.Length);
