module RecursionImpl

open UtilitiesImpl

// Euler problem 2 recursion
let sumRec border predicate =
    let mutable sum = 0
    let mutable i = 1

    while fibonacciRec i < border do
        if (predicate (fibonacciRec i)) then
            sum <- sumTwoDigits sum (fibonacciRec i)

        i <- inc i

    sum
// ------------------------------------------------------------

// Euler problem 2 tail recursion
let sumTailRec border predicate =
    let mutable sum = 0
    let mutable i = 1

    while fibonacciTailRecFunction i < border do
        if (predicate (fibonacciTailRecFunction i)) then
            sum <- sumTwoDigits sum (fibonacciTailRecFunction i)

        i <- inc i

    sum
// ------------------------------------------------------------
