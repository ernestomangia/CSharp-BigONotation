using BigONotation.Models;

namespace BigONotation;

public class Examples
{
    public static void Example1()
    {
        var (sum, product) = Algorithms.GetSumAndProduct(new[] { 10, 20, 30, 40 });

        var exampleTemplate = new ExampleTemplate
        {
            Title = "Example 1",

            Algorithm = @"
        public static (int sum, int product) GetSumAndProduct(int[] array)
        {
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
        }",

            Test = "GetSumAndProduct(new[] { 10, 20, 30, 40 })",

            Output = $@"
        Sum = {sum} 
        Product = {product}",

            Summary = @"
        Time complexity: O(N)
        Iterates over over an array of N size - from 0 to its length. We don't care about iterating it twice.
        Time will increase linearly with the size of the array.
        
        Space complexity: O(N)
        Memory usage will increase linearly with the length of the array."
        };

        WriteExampleTemplate(exampleTemplate);
    }

    public static void Example2()
    {
        var pairsAsString = Algorithms.GetPairsAsString(new[] { 10, 20, 30, 40 });

        var exampleTemplate = new ExampleTemplate
        {
            Title = "Example 2",

            Algorithm = @"
        public static void GetPairsAsString(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array.Length; j++)
                {
                    Console.WriteLine(array[i] + "","" + array[j]);
                }
            }
        }",

            Test = "GetPairsAsString(new[] { 10, 20, 30, 40 })",

            Output = $@"
{pairsAsString}",

            Summary = @"
        Time complexity: O(N)
        The inner loop iterates from 0 to array length. And this inner loop is call N times by the outer loop.
        So this is O(NxN) or O(N^2) time complexity
        
        Space complexity: O(N)
        Memory usage will increase linearly with the length of the array."
        };

        WriteExampleTemplate(exampleTemplate);
    }

    public static void Example3()
    {
        var sum = Algorithms.GetSum(5);

        var exampleTemplate = new ExampleTemplate
        {
            Title = "Example 3",

            Algorithm = @"
        public static int Sum(int n)
        {
            return n <= 0
                ? 0
                : n + Sum(n - 1);
        }",

            Test = "Sum(5)",

            Output = $@"
        {sum}",

            Summary = @"
        5 + GetSum(4);                     // 15  
            -> 4 + GetSum(3);              // 10  
                -> 3 + GetSum(2);          // 6 
                    -> 2 + GetSum(1);      // 3
                        -> 1 + GetSum(0);  // 1
                            -> 0;          // 0

        Time complexity: O(N)
        Time will increase linearly with the value of n. As long as n is greater, it'll take more time to process.
        
        Space complexity: O(N)
        A recursive method like this one uses stack space because each call will add a level on the stack.
        Meaning space will increase linearly with the value of n."
        };

        WriteExampleTemplate(exampleTemplate);
    }

    public static void Example4()
    {
        var sum = Algorithms.NonRecursiveSum(5);

        var exampleTemplate = new ExampleTemplate
        {
            Title = "Example 4",

            Algorithm = @"
        public static int NonRecursiveSum(int n)
        {
            var total = 0;

            for (var i = 0; i < n; i++)
            {
                total += i;
            }

            return total;
        }",

            Test = "NonRecursiveSum(5)",

            Output = $@"
        {sum}",

            Summary = @"
        Time complexity: O(N)
        Time will increase linearly with the value of n. As long as n is greater, it'll take more time to process.
        
        Space complexity: O(1)
        The sum is accumulated using one variable.
        Meaning space will always be constant independently of the value of n."
        };

        WriteExampleTemplate(exampleTemplate);
    }

    public static void Example5()
    {
        var exampleTemplate = new ExampleTemplate
        {
            Title = "Example 5",

            Algorithm = "var array = new[] { 100, 200, 300, 400 }",

            Test = "N/A",

            Output = "N/A",

            Summary = @"
        Space complexity: O(N)
        A one dimensional array requires O(N) space."
        };

        WriteExampleTemplate(exampleTemplate);
    }

    public static void Example6()
    {
        var sum = Algorithms.PairSumSequence(5);

        var exampleTemplate = new ExampleTemplate
        {
            Title = "Example 5",

            Algorithm = @"
        public static int PairSumSequence(int n)
        {
            var sum = 0;
            for (var i = 0; i < n; i++)
            {
                sum += PairSum(i, i + 1);
            }

            return sum;
        }

        private static int PairSum(int a, int b)
        {
            return a + b;
        }",

            Test = "PairSumSequence(5)",

            Output = $@"
        {sum}",

            Summary = @"
        Time complexity: O(N)
        Time will increase linearly with the value of n.
        
        Space complexity: O(1)
        PairSum will be call around N times however those calls don't exist simultaneously on the stack.
        So this example only requires O(1) space."
        };

        WriteExampleTemplate(exampleTemplate);
    }

    #region Private Method(s)

    private static void WriteExampleTemplate(ExampleTemplate exampleTemplate)
    {
        Console.WriteLine($@"
************************************************ {exampleTemplate.Title} ************************************************
    
    # Algorithm:
        {exampleTemplate.Algorithm}

    # Test:
        {exampleTemplate.Test} 
        
    # Output:
        {exampleTemplate.Output} 

    # Summary:
        {exampleTemplate.Summary} 

************************************************ /{exampleTemplate.Title} ************************************************
        ");
    }

    #endregion
}