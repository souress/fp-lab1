module Euler29.MapImpl

let generatePowersListWithMap a border =
    let baseRange = [ a..border ]
    let exponentRange = [ 2..border ]

    baseRange
    |> List.collect (fun a -> exponentRange |> List.map (fun b -> float a ** float b))

let distinctPowersWithMapCount a border =
    generatePowersListWithMap a border |> List.distinct |> List.length
