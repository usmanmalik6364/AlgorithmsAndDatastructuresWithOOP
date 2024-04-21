

public static class InsertionSort {
    public static int[] Sort(int[] arr){
        //the idea behind insertions sort is what?
        // you compare two elements and you see if they are bigger, whenever you find an element that is like
        //smaller than the previous one, you try and insert it into its appropriate position in the array.

        //lets see how the code will work 

        for (int i = 1; i< arr.Length; i++){
            //second pointer
            int j = i -1;
            //now try and see what the position at j hold
            while ( j >=0  && arr [j+1] < arr [j]){
                //[4,3,2,1]
                var temp = arr[j + 1];
                arr[j+1] = arr [j];
                arr[j] = temp;                
                j--;
                arr.ToList().ForEach(Console.WriteLine);
            }
        }
        Console.WriteLine("\n\n");
        arr.ToList().ForEach(s => Console.WriteLine($"{s}"));
        return arr;
    }
}