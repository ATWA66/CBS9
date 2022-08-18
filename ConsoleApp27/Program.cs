//4
int[] add(int[] arr, int num)
{
    int [] temp = new int[arr.Length+1];
    for (int i = 0; i < arr.Length; i++)
    {
        temp[i]=arr[i];
    }
    temp[arr.Length]=num;
    return temp; 
}
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, };
int[] arr2  =add(arr, 9);
for (int i = 0; i < arr2.Length; i++)
    Console.WriteLine("1.{0}", arr2[i]);
int[] add2(int[] arr, int num)
{
    int[] temp = new int[arr.Length + 1];
    for (int i = 1; i < arr.Length+1; i++)
    {
        temp[i] = arr[i-1];
    }
    temp[0] = num;
    return temp;
}
int[] arr3 = add2(arr, 9);
for (int i = 0; i < arr3.Length; i++)
    Console.WriteLine("2.{0}", arr3[i]);