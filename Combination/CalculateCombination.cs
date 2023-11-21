namespace Combination
{
    public class CalculateCombination
    {
        private static long Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
        public static long Calculate(int n, int k)
        {
            if ( n < 0 || k < 0)
            {
                throw new ArgumentException("K and N should be positive numbers");
            }

            if (k > n)
            {
                throw new ArgumentException("K can not be bigger than N");
            }
            long result=Factorial(n)/(Factorial(n-k)*Factorial(k));
            return result;
        }
    }
}