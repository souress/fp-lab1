module Euler2.RecursionImpl

// non-tail recursion
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
// ------------------------------------------------------------

// tail recursion
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
// ------------------------------------------------------------
