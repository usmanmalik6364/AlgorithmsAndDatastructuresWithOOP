public class SumUsingRecursion{

    public int Sum(int[] arr,int sum=0,int indx=0){
        if(indx >= arr.Length)
            return sum;
        else{
            sum += arr[indx];
            indx++;
            return Sum(arr,sum,indx);
        }
    }
}