
public static class StringApiVersionCompare{
    static int VersionCompare( string version1, string version2 ) {
		 //Insert your code here 
		 
        // I will translate each string to an int so that I can perform comparison
        // Basic intuition is that I will loop through the string and if a preeceding number in the string
        //is greater than the second one then its a larger number
        int num1 = 0, num2 = 0; 
    
        // loop until both string are 
        // processed 
        for (int i = 0, j = 0; (i < version1.Length || j < version2.Length);) 
        {
        
        // storing numeric part of 
        // version 1 in vnum1 
        while (i < version1.Length && version1[i] != '.')
        { 
            //version1[i] - '0' will ensure that the number is extracted from char
            num1 = num1 * 10 + (version1[i] - '0'); 
            i++; 
        } 
    
        // storing numeric part of 
        // version 2 in vnum2 
        while (j < version2.Length && version2[j] != '.') 
        { 
            //version1[i] - '0' will ensure that the number is extracted from char
            num2 = num2 * 10 + (version2[j] - '0'); 
            j++; 
        } 
    
        if (num1 > num2) 
            return 1; 
        if (num2 > num1) 
            return -1; 
    
        //if the variables are equal that means we haven't yet found a greater number
        //we can safely reset and go for next numeric part of the loop
        num1 = num2 = 0; 
        i++; 
        j++; 
    } 
    return 0; 
		}
}