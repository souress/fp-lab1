module ModularImpl

open UtilitiesImpl

let filter_and_sum_fibonacci_sequence border predicate =
    generate_fibonacci_sequence_list border |> filter_list predicate |> sum_list
