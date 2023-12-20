module Euler29.MapImpl

let generatePowersListWithMap a border =
    let baseRange = [a..border]
    let exponentRange = [2..border]

    let powersList =
        List.map (fun a ->
            List.map (fun b -> float(a) ** float(b)) exponentRange
        ) baseRange

    powersList |> List.concat

let distinctPowersWithMapCount a border =
    generatePowersListWithMap a border |> List.distinct |> List.length
