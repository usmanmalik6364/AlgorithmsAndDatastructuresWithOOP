public class BinarySearch{
    //returns the index in the array
    public int BinarySearchOnArray(int [] sortedArray,int elementToSearch){
        
        int high = sortedArray.Length -1;
        int low = 0;

        while(low<=high){
            int mid = (low+high)/2;
            var guess = sortedArray[mid];
            if(guess==elementToSearch)
                return mid;
            if(guess > elementToSearch)
                high = mid -1;
            else
                low = mid +1;
        }

        return -1;
    }

}