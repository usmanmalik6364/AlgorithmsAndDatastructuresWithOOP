
public class Factorial{

    public static int _Factorial(int n , int fac = 1){
        if(n==0 || n ==1)
            return fac;
        fac =  fac * n ;
        n--;
        return _Factorial(n,fac);
    }
}