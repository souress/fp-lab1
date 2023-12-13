module MapImpl

open UtilitiesImpl

let fibonacciWithMap n = // TODO fix shitcode
    [ 1..n ] |> List.map fibonacciRec

let sumOfFibonacciWithWithMap border predicate =
    let mutable n = 1

    while fibonacciRec n < border do
        n <- inc n

    fibonacciWithMap n |> filterList predicate |> sumList
