module Euler29.RecursionImpl

open UtilitiesImpl

// tail recursion
let rec distinctPowersTailRecSet a border set =
    if a > border then
        set
    else
        distinctPowersTailRecSet (a + 1.0) border (calculatePowersSet a 2 border set)

let distinctPowersTailRecCount a border =
    distinctPowersTailRecSet a border Set.empty |> Set.count
// ------------------------------------------------------------

// non-tail recursion
let rec distinctPowersNonTailRecSet a border set =
    if a > border then
        set
    else
        Set.union set (distinctPowersNonTailRecSet (a + 1.0) border (calculatePowersSet a 2 border set))

let distinctPowersNonTailRecCount a border =
    distinctPowersTailRecSet a border Set.empty |> Set.count
// ------------------------------------------------------------
