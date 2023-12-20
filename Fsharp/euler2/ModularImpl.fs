module Euler2.ModularImpl

open UtilitiesImpl

let filterAndSumFibonacciSequence border predicate =
    generateFibonacciSequenceList border |> filterList predicate |> sumList
