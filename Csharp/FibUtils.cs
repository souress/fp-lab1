namespace ConsoleApp1;

public static class FibUtils
{
    public static int SumOfEvenFibonacciTermsRec(int border)
    {
        var sum = 0;
        for (var i = 1; Fib(i) < border; i++)
        {
            var fib = Fib(i);

            if (fib % 2 == 0) sum += fib;
        }

        return sum;
    }

    public static int SumOfEvenFibonacciTermsTail(int border)
    {
        var sum = 0;
        for (var i = 1; FibTail(i) < border; i++)
        {
            var fib = FibTail(i);

            if (fib % 2 == 0) sum += fib;
        }

        return sum;
    }

    private static int Fib(int n) => n < 2 ? n : Fib(n - 1) + Fib(n - 2);

    private static int FibTail(int n) => FibTailRecursion(n, 1, 1);
    
    private static int FibTailRecursion(int n, int x, int y) =>
        n switch
        {
            1 => x,
            2 => y,
            _ => FibTailRecursion(n - 1, y, x + y)
        };
}