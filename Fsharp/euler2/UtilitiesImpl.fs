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
        list <- list @ [fibonacciRec i]
        i <- inc i

    list
