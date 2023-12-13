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
printfn $"\tUsing recursion: {sum_rec border predicate}"
printfn $"\tUsing tail recursion: {sum_tail_rec border predicate}"
printfn $"\tUsing modular implementation: {filter_and_sum_fibonacci_sequence border predicate}"
printfn $"\tUsing modular implementation (generating sequence with map): {sum_of_fibonacci_with_map border predicate}"
printfn $"\tUsing fold generation: {sum_fibonacci_fold border predicate}"
printfn $"\tUsing infinite sequence: {sum_endless_sequence border predicate}"
