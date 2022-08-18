//6
int[] myArr = { 1, 2, 3, 4, 5, 6, 7, 8 };
Console.WriteLine("before");
for (int i = 0; i < myArr.Length; i++)
{
    Console.WriteLine(myArr[i]);
}
Console.WriteLine("after");
for (int i = myArr.Length - 1; i >= 0; i--)
{
    Console.WriteLine(myArr[i]);
}