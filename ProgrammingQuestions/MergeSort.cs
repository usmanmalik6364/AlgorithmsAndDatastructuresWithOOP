

public static class MergeSort{

    public static int[] mergeSort(int[] arr, int start, int end){
        
        if(end-start + 1 <=1)
            return arr;
        int mid = (start + end) /2 ;
        mergeSort(arr,start,mid);
        mergeSort(arr,mid+1,end);
        merge(arr,start,mid,end);
        return arr;
    }

    private static void merge(int[] arr, int start, int mid, int end)
{
    int leftSize = mid - start + 1;
    int rightSize = end - mid;

    int[] left = new int[leftSize];
    int[] right = new int[rightSize];

    // Copy elements from arr to left and right arrays
    for (int i = 0; i < leftSize; i++)
    {
        left[i] = arr[start + i];
    }

    for (int j = 0; j < rightSize; j++)
    {
        right[j] = arr[mid + 1 + j];
    }

    int leftIndex = 0;
    int rightIndex = 0;
    int mergedIndex = start;

    // Merge left and right arrays back into arr
    while (leftIndex < leftSize && rightIndex < rightSize)
    {
        if (left[leftIndex] <= right[rightIndex])
        {
            arr[mergedIndex] = left[leftIndex];
            leftIndex++;
        }
        else
        {
            arr[mergedIndex] = right[rightIndex];
            rightIndex++;
        }
        mergedIndex++;
    }

    // Copy remaining elements of left array
    while (leftIndex < leftSize)
    {
        arr[mergedIndex] = left[leftIndex];
        leftIndex++;
        mergedIndex++;
    }

    // Copy remaining elements of right array
    while (rightIndex < rightSize)
    {
        arr[mergedIndex] = right[rightIndex];
        rightIndex++;
        mergedIndex++;
    }
}

   }