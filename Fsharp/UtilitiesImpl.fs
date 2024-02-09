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

let rec findIndexOfBorderlineFibonacciElement n border =
    match fibonacciRec n >= border with
    | true -> n
    | false -> findIndexOfBorderlineFibonacciElement (n + 1) border
// ------------------------------------------------------------

let generateFibonacciSequenceList border =
    let n = findIndexOfBorderlineFibonacciElement 1 border
    [ 1 .. n - 1 ] |> List.map fibonacciRec
// ------------------------------------------------------------

let rec power a b =
    match b = 0I with
    | true -> 1
    | false -> a * power a (b - 1I)

let rec calculatePowersSet a b border set =
    match float b > border with
    | true -> set
    | false -> calculatePowersSet a (inc b) border (Set.add (a ** float b) set)
// ------------------------------------------------------------

let rec generatePowersList a border list =
    match a > border with
    | true -> list
    | false ->
        List.append list (generatePowersList (a + 1.0) border (Set.toList (calculatePowersSet a 2 border Set.empty)))
// ------------------------------------------------------------

let generateUsingSequence =
    seq {
        for a in 2..100 do
            for b in 2..100 -> a, b
    }
    |> Seq.map (fun (a, b) -> float a ** b)
    |> Seq.distinct
    |> Seq.length
