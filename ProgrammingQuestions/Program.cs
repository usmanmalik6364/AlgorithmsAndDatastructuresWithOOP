

int[] arr = new int[]{9,8,7,6,5,4,3,2,1};
arr = MergeSort.mergeSort(arr,0,arr.Length-1);

foreach (var item in arr)
{
  Console.Write($" {item} ");
}