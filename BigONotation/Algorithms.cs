using System.Text;

namespace BigONotation
{
    public static class Algorithms
    {
        /// <summary>
        /// Gets the sum of all elements and the product of all elements
        /// </summary>
        /// <param name="array">Array of integers</param>
        /// <returns>A tuple with 2 values: sum and product</returns>
        public static (int sum, int product) GetSumAndProduct(int[] array)
        {
            /*
             * Time complexity: O(N)
             * Iterates over over an array of N size - from 0 to its length. We don't care about iterating it twice.
             * Time will increase linearly with the size of the array.
             *
             * Space complexity: O(N)
             * Memory usage will increase linearly with the length of the array.
             *
             */
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

            return (sum, product);
        }

        /// <summary>
        /// Gets a string containing pairs of integers in an array
        /// </summary>
        /// <param name="array">Array of integers</param>
        /// <returns>An string with pairs of integers</returns>
        public static string GetPairsAsString(int[] array)
        {
            /*
             * Time complexity: O(NxN) or O(N^2)
             * The inner loop iterates from 0 to array length. And this inner loop is call N times by the outer loop.
             * So this is O(NxN) or O(N^2) time complexity
             *
             * Space complexity: O(N)
             * Memory usage will increase linearly with the length of the array.
             *
             */
            var sb = new StringBuilder();

            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array.Length; j++)
                {
                    sb.AppendLine("\t" + array[i] + "," + array[j]);
                }
            }

            return sb.ToString();
        }

        public static int GetSum(int n)
        {
            /*
             * Time complexity: O(N)
             * Time will increase linearly with the value of n. As long as n is greater, it'll take more time to process.
             *
             * Space complexity: O(N)
             * A recursive method like this one uses stack space because each call will add a level on the stack.
             * Meaning space will increase linearly with the value of n.
             *
             */
            return n <= 0
                ? 0
                : n + GetSum(n - 1);
        }

        public static int NonRecursiveSum(int n)
        {
            /*
             * Time complexity: O(N)
             * Time will increase linearly with the value of n. As long as n is greater, it'll take more time to process.
             *
             * Space complexity: O(1)
             * The sum is accumulated using one variable.
             * Meaning space will always be constant independently of the value of n.
             *
             */

            var total = 0;

            for (var i = 0; i <= n; i++)
            {
                total += i;
            }

            return total;
        }

        public static int PairSumSequence(int n)
        {
            /*
             * Time complexity: O(N)
             * Time will increase linearly with the value of n.
             * 
             * Space complexity: O(1)
             * PairSum will be call around N times however those calls don't exist simultaneously on the stack.
             * So this example only requires O(1) space.
             *
             */

            var sum = 0;
            for (var i = 0; i < n; i++)
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
