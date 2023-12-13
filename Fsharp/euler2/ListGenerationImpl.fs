module ListGenerationImpl

open UtilitiesImpl

let fibonacci_fold n =
    [ 1..n ] |> List.fold (fun (a, b) _ -> b, a + b) (0, 1) |> fst

let sum_endless_sequence border predicate =
    Seq.initInfinite fibonacci_fold
    |> Seq.skip 1
    |> Seq.takeWhile (less_than border)
    |> Seq.filter predicate
    |> Seq.toList
    |> sum_list

let sum_fibonacci_fold border predicate =
    let mutable i = 1
    let mutable sum = 0

    while fibonacci_fold i < border do
        if (predicate (fibonacci_fold i)) then
            sum <- sum_two_digits sum (fibonacci_fold i)

        i <- inc i

    sum
