module Program

open RecursionImpl
open ModularImpl
open UtilitiesImpl
open MapImpl
open ListGenerationImpl

printfn "Euler 2 problem"
let border = 4000000 //TODO from args?
let predicate = isEven
printfn "Sum of the even-valued terms of Fibonacci sequence"
printfn $"\tUsing recursion: {sumRec border predicate}"
printfn $"\tUsing tail recursion: {sumTailRec border predicate}"
printfn $"\tUsing modular implementation: {filterAndSumFibonacciSequence border predicate}"
printfn $"\tUsing modular implementation (generating sequence with map): {sumOfFibonacciWithWithMap border predicate}"
printfn $"\tUsing fold generation: {sumFibonacciFold border predicate}"
printfn $"\tUsing infinite sequence: {sumEndlessSequence border predicate}"
