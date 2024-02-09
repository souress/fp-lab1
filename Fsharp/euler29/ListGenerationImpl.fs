module Euler29.ListGenerationImpl

open UtilitiesImpl

let distinctPowersSeqCount a border =
    seq {
        for a in a..border do
            for b in 2..border do
                yield float (a) ** float (b)
    }
    |> Set.ofSeq
    |> Set.count

let infinitePowers baseValue initPower =
    initPower
    |> Seq.unfold (fun powValue -> Some(float baseValue ** int powValue, powValue + 1))


let takePowers a powerBorder =
    infinitePowers a 2 |> Seq.take (powerBorder - 1)

let distinctPowersWithInfiniteSequenceCount border =
    Seq.initInfinite inc
    |> Seq.skip 1
    |> Seq.takeWhile (lessThan (border + 1))
    |> Seq.collect (fun x -> takePowers x border)
    |> Seq.distinct
    |> Seq.length
