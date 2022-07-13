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

Console.WriteLine("************************************************ Big O Notation ************************************************");

Examples.Example1();

Examples.Example2();

Examples.Example3();

Examples.Example4();

Examples.Example5();

Examples.Example6();

Console.ReadLine();