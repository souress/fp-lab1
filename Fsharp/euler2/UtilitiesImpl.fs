module UtilitiesImpl

let isEven x = x % 2 = 0
let inc x = x + 1
let sum_two_digits a b = a + b
let sum_list = List.fold (+) 0
let filter_list predicate = List.filter predicate
let less_than value = fun x -> x < value

// fibonacci sequence recursion
let rec fibonacci_rec n =
    match n with
    | 1
    | 2 -> 1
    | n -> fibonacci_rec (n - 1) + fibonacci_rec (n - 2)
// ------------------------------------------------------------

// fibonacci sequence tail recursion
let rec fibonacci_tail_rec n previous current =
    match n with
    | 1 -> previous
    | 2 -> current
    | n -> fibonacci_tail_rec (n - 1) current (previous + current)

let fibonacci_tail_rec_f n = fibonacci_tail_rec n 1 1
// ------------------------------------------------------------

let generate_fibonacci_sequence_list border =
    let mutable list = []
    let mutable i = 1

    while fibonacci_rec i < border do
        list <- list @ (fibonacci_rec i) :: []
        i <- inc i

    list
