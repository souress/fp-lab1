module Euler2.RecursionImpl

// non-tail recursion
let rec fibonacciSumNonTailRec a b border predicate =
    if a > border then
        0
    else
        let currentTerm = if predicate a then a else 0
        currentTerm + fibonacciSumNonTailRec b (a + b) border predicate

let fibonacciSumNonTailRecFunction border predicate =
    fibonacciSumNonTailRec 0 1 border predicate
// ------------------------------------------------------------

// tail recursion
let rec fibonacciSumTailRec a b border predicate acc =
    if a > border then
        acc
    else
        fibonacciSumTailRec b (a + b) border predicate (if predicate a then acc + a else acc)

let fibonacciSumTailRecFunction border predicate =
    fibonacciSumTailRec 0 1 border predicate 0
// ------------------------------------------------------------
