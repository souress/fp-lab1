module Euler2.MapImpl

open UtilitiesImpl

let fibonacciWithMap n = [ 1..n ] |> List.map fibonacciRec

let sumOfFibonacciWithWithMap border predicate =
    fibonacciWithMap (findIndexOfBorderlineFibonacciElement 1 border)
    |> filterList predicate
    |> sumList
