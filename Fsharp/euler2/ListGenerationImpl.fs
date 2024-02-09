module Euler2.ListGenerationImpl

open UtilitiesImpl

let fibonacciFold n =
    ((0, 1), [ 1..n ]) ||> List.fold (fun (a, b) _ -> b, a + b) |> fst

let rec findIndexOfBorderlineFibonacciElementUsingFold a border =
    match fibonacciFold a >= border with
    | true -> a
    | false -> findIndexOfBorderlineFibonacciElementUsingFold (a + 1) border

let sumFibonacciInfiniteSequence border predicate =
    Seq.initInfinite fibonacciFold
    |> Seq.skip 1
    |> Seq.takeWhile (lessThan border)
    |> Seq.filter predicate
    |> Seq.toList
    |> sumList

let sumFibonacciFold border predicate =
    let n = findIndexOfBorderlineFibonacciElementUsingFold 1 border

    (0, [ 1..n ])
    ||> List.fold (fun sum index ->
        match predicate (fibonacciFold index) with
        | true -> sum + fibonacciFold index
        | _ -> sum)
