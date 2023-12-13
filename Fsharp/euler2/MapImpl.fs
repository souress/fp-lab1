module MapImpl

open UtilitiesImpl

let fibonacci_with_map n = // TODO fix shitcode
    [ 1..n ] |> List.map fibonacci_rec

let sum_of_fibonacci_with_map border predicate =
    let mutable n = 1

    while fibonacci_rec n < border do
        n <- inc n

    fibonacci_with_map n |> filter_list predicate |> sum_list
