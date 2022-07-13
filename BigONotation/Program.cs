using BigONotation;

/*
 * Credits to the book 'Cracking the Coding Interview' by Gayle Laakmann McDowell
 * 6th edition - 2015
 */

/*
 * Big O notation is a metric to measure an algorithm's efficiency.
 * It allows us to understand how the runtime scales, or in other words, describes the the rate of increase.
 * There are 2 variables of interest: Time and Space
 *
 * Time Complexity:
 *  O(1): time is constant. For any input, the time will be always the same
 *  O(N): time will increase linearly with he size of the input (N)
 *
 * Space Complexity (or amount of memory):
 *  How much memory your algorithm uses?
 *  The amount of memory (or space) that an algorithm consumes is another variable that matters
 *
 *  For example,
 *  A variable like 'var num = 10'             => requires O(1) space      
 *  Array of size N                            => requires O(N) space
 *  Array of size NxN (2-dimensional)          => requires O(N^2) space
 *
 *  Note: recursive methods also count for space because they use stack space for each call  
 *
 */

Console.WriteLine("******************************* Big O notation *******************************");

// Example 1
var sumAndProduct = Examples.SumAndProduct(new[] { 10, 20, 30, 40 });

Console.WriteLine($@"
# Example 1
    public static Tuple<int, int> SumAndProduct(int[] array)
    {{
        var sum = 0;
        var product = 1;

        foreach (var n in array)
        {{
            sum += n;
        }}

        foreach (var n in array)
        {{
            product *= n;
        }}

        return new Tuple<int, int>(sum, product);
    }}

# Test:
    SumAndProduct(new[] {{ 10, 20, 30, 40 }})
    
    Result: 
    Sum = {sumAndProduct.Item1} 
    Product = {sumAndProduct.Item2}

# Conclusion:
    This is O(N) time because we are iterating over an array of N size
    Time will increase linearly with the size of the array
");

Console.WriteLine("---------------------------------------------------------------------------------");

var pairsAsString = Examples.GetPairsAsString(new[] { 10, 20, 30, 40 });

// Example 2
Console.WriteLine($@"
# Example 2
    public static void GetPairsAsString(int[] array)
    {{
        for (var i = 0; i < array.Length; i++)
        {{
            for (var j = 0; j < array.Length; j++)
            {{
                Console.WriteLine(array[i] + "","" + array[j]);
            }}
        }}
    }}

# Test: 
    GetPairsAsString(new[] {{ 10, 20, 30, 40 }});
    
    Result:    
{pairsAsString}

# Conclusion:
    The inner loop iterates O(N) times (from 0 to array length). And this inner loop is call N times by the outer loop
    So this is O(NxN) or O(N^2) time complexity
");

Console.WriteLine("---------------------------------------------------------------------------------");

// Example 3
var sum = Examples.Sum(5);

Console.WriteLine($@"
# Example 3
    public static int Sum(int n)
    {{
        return n <= 0
            ? 0
            : n + Sum(n - 1);
    }}

# Test: 
    Sum(5);
    Result: {sum}

# Conclusion:
    5 + Sum(4);                     // 15  
        -> 4 + Sum(3);              // 10  
            -> 3 + Sum(2);          // 6 
                -> 2 + Sum(1);      // 3
                    -> 1 + Sum(0);  // 1
                        -> 0;       // 0

    A recursive method like this one uses stack space because each call will add a level on the stack.
    Meaning space will increase linearly with n. This requires O(N) space.
");

Console.WriteLine("---------------------------------------------------------------------------------");

var total = 0;

for (var i = 0; i < 10; i++)
{
    total += i;
}

Console.WriteLine($@"
# Example 4
    var total = 0;
    for (int i = 0; i < 10; i++)
    {{
        total += i;
    }}

# Test:
    Result: {total}

# Conclusion:
    This requires O(1) space
");

Console.WriteLine("---------------------------------------------------------------------------------");

Console.WriteLine($@"
# Example
    var array = new[] {{ 100, 200, 300, 400 }};

# Conclusion:
    This requires O(N) space
");