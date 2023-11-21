namespace Combination
{
    public class CalculateCombination
    {
        private static int Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
        public static int Calculate(int n, int k)
        {
            int result=Factorial(n)/(Factorial(n-k)*Factorial(k));
            return result;
        }
    }
}