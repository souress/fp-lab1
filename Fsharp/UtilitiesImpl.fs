module UtilitiesImpl

let isEven x = x % 2 = 0
let inc x = x + 1
let sumTwoDigits a b = a + b
let sumList = List.fold (+) 0
let filterList predicate = List.filter predicate
let lessThan value = fun x -> x < value

// fibonacci sequence recursion
let rec fibonacciRec n =
    match n with
    | 1
    | 2 -> 1
    | n -> fibonacciRec (n - 1) + fibonacciRec (n - 2)
// ------------------------------------------------------------

// fibonacci sequence tail recursion
let rec fibonacciTailRec n previous current =
    match n with
    | 1 -> previous
    | 2 -> current
    | n -> fibonacciTailRec (n - 1) current (previous + current)

let fibonacciTailRecFunction n = fibonacciTailRec n 1 1
// ------------------------------------------------------------

let generateFibonacciSequenceList border =
    let mutable list = []
    let mutable i = 1

    while fibonacciRec i < border do
        list <- list @ [ fibonacciRec i ]
        i <- inc i

    list
// ------------------------------------------------------------

let rec calculatePowersSet a b border set =
    if float b > border then
        set
    else
        calculatePowersSet a (inc b) border (Set.add (a ** float b) set)
// ------------------------------------------------------------

let rec generatePowersList a border list =
    if a > border then
        list
    else
        List.append list (generatePowersList (a + 1.0) border (Set.toList (calculatePowersSet a 2 border Set.empty)))
// ------------------------------------------------------------

let generateUsingSequence =
    seq {
        for a in 2I..100I do
        for b in 2..100 -> a,b
        }
    |> Seq.map (fun (a,b) -> pown a b)
    |> Seq.distinct
    |> Seq.length