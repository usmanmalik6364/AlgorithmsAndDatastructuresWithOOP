
using System.Numerics;

namespace ProgrammingQuestions
{
    public class FibonacciSeries
    {
        private int _num;
        public FibonacciSeries(int num)
        {
            _num = num;
        }
        public void printFibSeries()
        {
            if (_num < 1)
            {
                Console.WriteLine("Fib Number \t" + 0);
                return;
            }
            var fibArray = new BigInteger[_num];
            fibArray[0] = 0;
            Console.WriteLine("Fib Number \t" + fibArray[0]);
            if (_num > 1)
            {
                fibArray[1] = 1;
                Console.WriteLine("Fib Number \t" + fibArray[1]);
                for (int i = 2; i < _num; i++)
                {
                    fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
                    Console.WriteLine("Fib Number \t" + fibArray[i]);
                }
            }
        }
    }
}
