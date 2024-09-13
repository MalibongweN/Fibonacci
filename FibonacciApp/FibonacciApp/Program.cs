using System;
using System.Collections.Generic;

public class FibonacciApp
{
    //store previously computed Fibonacci values
    private static Dictionary<int, long> memo = new Dictionary<int, long>();

   
    public static long FibonacciMemoized(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        
        if (memo.ContainsKey(n))
        {
            return memo[n];
        }

       
        long result = FibonacciMemoized(n - 1) + FibonacciMemoized(n - 2);
        memo[n] = result;

        return result;
    }

    public static void Main()
    {
        Console.Write("Enter the value of n to compute Fibonacci(n): ");
        int n = int.Parse(Console.ReadLine());

      
        memo.Clear();

       
        var startTime = DateTime.Now;
        long result = FibonacciMemoized(n);
        var endTime = DateTime.Now;

        Console.WriteLine($"Fibonacci({n}) = {result}");
        Console.WriteLine($"Time taken with memoization: {(endTime - startTime).TotalMilliseconds} ms");
    }
}
