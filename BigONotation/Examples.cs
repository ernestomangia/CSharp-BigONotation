using System.Text;

namespace BigONotation
{
    public static class Examples
    {
        public static Tuple<int, int> SumAndProduct(int[] array)
        {
            // This is O(N) time because we are iterating over an array of N size
            // Time will increase linearly with the size of the array
            var sum = 0;
            var product = 1;

            foreach (var n in array)
            {
                sum += n;
            }

            foreach (var n in array)
            {
                product *= n;
            }

            return new Tuple<int, int>(sum, product);
        }

        public static string GetPairsAsString(int[] array)
        {
            // The inner loop iterates O(N) times which is call N times (by the outer loop)
            // So this is O(NxN) or O(N^2) time complexity
            var sb = new StringBuilder();

            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array.Length; j++)
                {
                    sb.AppendLine("    " + array[i] + "," + array[j]);
                }
            }

            return sb.ToString();
        }

        public static int Sum(int n)
        {
            // A recursive method like this one uses stack space because each call will add a level on the stack.
            // Meaning space will increase linearly with n. This requires O(N) space.
            return n <= 0
                ? 0
                : n + Sum(n - 1);
        }

        public static int PairSumSequence(int n)
        {
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += PairSum(i, i + 1);
            }

            return sum;
        }

        #region Private Method(s)

        private static int PairSum(int a, int b)
        {
            return a + b;
        }

        #endregion
    }
}
