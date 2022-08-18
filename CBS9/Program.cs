//3
int[] MyReverse(int[] array){
    int[] myArr = new int[array.Length];
    for (int i =0, j= array.Length-1 ; i< array.Length; i++ ,j--)
    {
        myArr[i] = array[j];    
    }
    return myArr;
}
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, };
int[] myArr= MyReverse(arr); 
for (int i = 0; i < myArr.Length; i++)
    Console.WriteLine("1.{0}", myArr[i]);
int index = 7, count = 3;
int[] myArr1 = SubArray(arr, index, count);
for (int i = 0; i < myArr1.Length; i++)
    {
    Console.WriteLine("2.{0}", myArr1[i]);
}
int[] SubArray(int[] array, int index, int count)
{
    int[] myArr = new int[count];
    for (int i = 0; i < count; i++)
    {
        if (index + i > (array.Length-1))
            myArr[i] = 1;
        else
        myArr[i] = array[index+i];
    }
    return myArr;
}