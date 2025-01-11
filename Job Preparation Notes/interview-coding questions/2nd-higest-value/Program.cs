int[] arr = { 12,33,11,5,3,45,23};
int l = arr.Length;
Array.Sort(arr);
Console.WriteLine(arr[l-2]);
for(int i = 0; i < l; i++)
{
    Console.Write(arr[i] + " ");
}
//Console.WriteLine(string.Join(" ",arr));

