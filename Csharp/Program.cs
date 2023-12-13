namespace ConsoleApp1;

public static class Program
{
    public static void Main(string[] args) //TODO border from args
    {
        Console.WriteLine("Euler 2 problem");
        const int border = 4000000;
        Console.WriteLine("Sum of the even-valued terms of Fibonacci sequence using recursion: " +
                          $"{FibUtils.SumOfEvenFibonacciTermsRec(border)}");
        Console.WriteLine("Sum of the even-valued terms of Fibonacci sequence using tail recursion: " +
                          $"{FibUtils.SumOfEvenFibonacciTermsTail(border)}");
        
    }
}