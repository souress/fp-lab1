module RecursionImpl

open UtilitiesImpl

// Euler problem 2 recursion
let sum_rec border predicate =
    let mutable sum = 0
    let mutable i = 1

    while fibonacci_rec i < border do
        if (predicate (fibonacci_rec i)) then
            sum <- sum_two_digits sum (fibonacci_rec i)

        i <- inc i

    sum
// ------------------------------------------------------------

// Euler problem 2 tail recursion
let sum_tail_rec border predicate =
    let mutable sum = 0
    let mutable i = 1

    while fibonacci_tail_rec_f i < border do
        if (predicate (fibonacci_tail_rec_f i)) then
            sum <- sum_two_digits sum (fibonacci_tail_rec_f i)

        i <- inc i

    sum
// ------------------------------------------------------------
