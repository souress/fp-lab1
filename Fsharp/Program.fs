﻿module Program

open Euler2.RecursionImpl
open Euler29.RecursionImpl
open Euler2.ModularImpl
open Euler29.ModularImpl
open UtilitiesImpl
open Euler2.MapImpl
open Euler29.MapImpl
open Euler2.ListGenerationImpl
open Euler29.ListGenerationImpl

printfn "Euler 2 problem"
let borderEuler2 = 4000000
let predicate = isEven
printfn "Sum of the even-valued terms of Fibonacci sequence"
printfn $"\tUsing non-tail recursion: {fibonacciSumNonTailRecFunction borderEuler2 predicate}"
printfn $"\tUsing tail recursion: {fibonacciSumTailRecFunction borderEuler2 predicate}"
printfn $"\tUsing modular implementation: {filterAndSumFibonacciSequence borderEuler2 predicate}"

printfn
    $"\tUsing modular implementation (generating sequence with map): {sumOfFibonacciWithWithMap borderEuler2 predicate}"

printfn $"\tUsing fold generation: {sumFibonacciFold borderEuler2 predicate}"
printfn $"\tUsing infinite sequence: {sumFibonacciInfiniteSequence borderEuler2 predicate}"

printfn "Euler 29 problem"
printfn "Amount of distinct terms are in the sequence generated by a^b for 2 <= a <= 100 and 2 <= b <= 100"
let a = 2
let borderEuler29 = 100
printfn $"\tUsing non-tail recursion: {distinctPowersNonTailRecCount a borderEuler29}"
printfn $"\tUsing tail recursion: {distinctPowersTailRecCount a borderEuler29}"
printfn $"\tUsing modular implementation: {distinctPowersModularCount a borderEuler29}"
printfn $"\tUsing modular implementation (generating sequence with map): {distinctPowersWithMapCount a borderEuler29}"
printfn $"\tUsing infinite sequence: {distinctPowersWithInfiniteSequenceCount borderEuler29}"
