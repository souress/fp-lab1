module Euler2.ListGenerationImpl

open UtilitiesImpl

let fibonacciFold n =
    [ 1..n ] |> List.fold (fun (a, b) _ -> b, a + b) (0, 1) |> fst

let sumEndlessSequence border predicate =
    Seq.initInfinite fibonacciFold
    |> Seq.skip 1
    |> Seq.takeWhile (lessThan border)
    |> Seq.filter predicate
    |> Seq.toList
    |> sumList

let sumFibonacciFold border predicate =
    let mutable i = 1
    let mutable sum = 0

    while fibonacciFold i < border do
        if (predicate (fibonacciFold i)) then
            sum <- sumTwoDigits sum (fibonacciFold i)

        i <- inc i

    sum
