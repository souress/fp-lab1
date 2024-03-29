# Функциональное программирование. Лабораторная работа №1.

Вариант: 2, 29.


Цель: освоить базовые приёмы и абстракции функционального программирования: функции, поток управления и поток данных, сопоставление с образцом, рекурсия, свёртка, отображение, работа с функциями как с данными, списки.

## Условия задач

### Задача 2

By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.


### Задача 29

How many distinct terms are in the sequence generated by a^b for 2 <= a <= 100 and 2 <= b <= 100?


## Реализация

Решение представленных задач в императивном стиле на языке Golang

```csharp
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
```

```csharp
public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Euler 2 problem");
        const int border = 4000000;
        Console.WriteLine("Sum of the even-valued terms of Fibonacci sequence using recursion: " +
                          $"{FibUtils.SumOfEvenFibonacciTermsRec(border)}");
        Console.WriteLine("Sum of the even-valued terms of Fibonacci sequence using tail recursion: " +
                          $"{FibUtils.SumOfEvenFibonacciTermsTail(border)}");
        
        
        Console.WriteLine("Euler 29 problem");
        const int min = 2;
        const int max = 100;
        var lst = new List<double>();
        for (var a = min; a <= max; a++)
        {
            for (var b = min; b <= max; b++)
            {
                lst.Add(Math.Pow(a, b));
            }
        }
        var distinctResult = lst.Distinct().ToList();
        distinctResult.Sort();
        Console.WriteLine($"Amount of distinct terms are in the sequence generated by a^b for 2 <= a <= 100 and 2 <= b <= 100?: {distinctResult.Count}");
        Console.ReadLine();
    }
}
```

### F#: задача 2

- Рекурсия:
```fsharp
let rec fibonacciSumNonTailRec a b border predicate =
    match a > border with
    | true -> 0
    | false ->
        let currentTerm =
            match predicate a with
            | true -> a
            | false -> 0

        currentTerm + fibonacciSumNonTailRec b (a + b) border predicate

let fibonacciSumNonTailRecFunction border predicate =
    fibonacciSumNonTailRec 0 1 border predicate
```

- Хвостовая рекурсия:
```fsharp
let rec fibonacciSumTailRec a b border predicate acc =
    match a > border with
    | true -> acc
    | false ->
        fibonacciSumTailRec
            b
            (a + b)
            border
            predicate
            (match predicate a with
             | true -> acc + a
             | false -> acc)

let fibonacciSumTailRecFunction border predicate =
    fibonacciSumTailRec 0 1 border predicate 0
```

- Модульная реализация:
```fsharp
let rec findIndexOfBorderlineFibonacciElement n border =
    match fibonacciRec n >= border with
    | true -> n
    | false -> findIndexOfBorderlineFibonacciElement (n + 1) border

let generateFibonacciSequenceList border =
    let n = findIndexOfBorderlineFibonacciElement 1 border
    [ 1 .. n - 1 ] |> List.map fibonacciRec

let sumList = List.fold (+) 0

let filterAndSumFibonacciSequence border predicate =
    generateFibonacciSequenceList border |> filterList predicate |> sumList
```

- С использованием map:
```fsharp
let rec fibonacciRec n =
    match n with
    | 1
    | 2 -> 1
    | n -> fibonacciRec (n - 1) + fibonacciRec (n - 2)

let fibonacciWithMap n = [ 1..n ] |> List.map fibonacciRec

let rec findIndexOfBorderlineFibonacciElement n border =
    match fibonacciRec n >= border with
    | true -> n
    | false -> findIndexOfBorderlineFibonacciElement (n + 1) border

let sumOfFibonacciWithWithMap border predicate =
    fibonacciWithMap (findIndexOfBorderlineFibonacciElement 1 border)
    |> filterList predicate
    |> sumList
```

- Бесконечные списки:
```fsharp
let fibonacciFold n =
    ((0, 1), [ 1..n ]) ||> List.fold (fun (a, b) _ -> b, a + b) |> fst

let sumFibonacciInfiniteSequence border predicate =
    Seq.initInfinite fibonacciFold
    |> Seq.skip 1
    |> Seq.takeWhile (lessThan border)
    |> Seq.filter predicate
    |> Seq.toList
    |> sumList
```


### F#: задача 29

- Рекурсия:
```fsharp
let rec distinctPowersNonTailRecSet a border set =
    match a > border with
    | true -> set
    | false -> Set.union set (distinctPowersNonTailRecSet (a + 1.0) border (calculatePowersSet a 2 border set))

let distinctPowersNonTailRecCount a border =
    distinctPowersTailRecSet a border Set.empty |> Set.count
```

- Хвостовая рекурсия:
```fsharp
let rec distinctPowersTailRecSet a border set =
    match a > border with
    | true -> set
    | false -> distinctPowersTailRecSet (a + 1.0) border (calculatePowersSet a 2 border set)

let distinctPowersTailRecCount a border =
    distinctPowersTailRecSet a border Set.empty |> Set.count
```

- Модульная реализация:
```fsharp
let rec calculatePowersSet a b border set =
    match float b > border with
    | true -> set
    | false -> calculatePowersSet a (inc b) border (Set.add (a ** float b) set)

let rec generatePowersList a border list =
    match a > border with
    | true -> list
    | false ->
        List.append list (generatePowersList (a + 1.0) border (Set.toList (calculatePowersSet a 2 border Set.empty)))

let distinctPowersModularCount a border =
    generatePowersList a border List.Empty |> List.distinct |> List.length
```

- С использованием map:
```fsharp
let generatePowersListWithMap a border =
    let baseRange = [ a..border ]
    let exponentRange = [ 2..border ]

    baseRange
    |> List.collect (fun a -> exponentRange |> List.map (fun b -> float a ** float b))

let distinctPowersWithMapCount a border =
    generatePowersListWithMap a border |> List.distinct |> List.length
```

- Бесконечные списки:
```fsharp
let infinitePowers baseValue initPower =
    initPower
    |> Seq.unfold (fun powValue -> Some(float baseValue ** int powValue, powValue + 1))

let takePowers a powerBorder =
    infinitePowers a 2 |> Seq.take (powerBorder - 1)

let distinctPowersWithInfiniteSequenceCount border =
    Seq.initInfinite inc
    |> Seq.skip 1
    |> Seq.takeWhile (lessThan (border + 1))
    |> Seq.collect (fun x -> takePowers x border)
    |> Seq.distinct
    |> Seq.length
```

## Вывод

В результате выполнения данной лабораторной работы мною был получен практический опыт применения приёмов функционального
программирования, а также осознание различий и возможностей ленивых коллекций и итераторов.
