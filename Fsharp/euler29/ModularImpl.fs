module Euler29.ModularImpl

open UtilitiesImpl

let distinctPowersModularCount a border =
    generatePowersList a border List.Empty |> List.distinct |> List.length
