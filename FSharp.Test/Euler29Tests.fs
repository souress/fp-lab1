module Euler29Tests

open Xunit
open Euler29.RecursionImpl
open Euler29.ModularImpl
open Euler29.MapImpl
open Euler29.ListGenerationImpl

// RecursionImpl
[<Fact>]
let ``distinctPowersTailRecCount should return the correct count`` () =
    Assert.Equal(15, (distinctPowersTailRecCount 2.0 5.0))
    Assert.Equal(69, (distinctPowersTailRecCount 2.0 10.0))
    Assert.Equal(9183, (distinctPowersTailRecCount 2.0 100.0))

[<Fact>]
let ``distinctPowersNonTailRecCount should return the correct count`` () =
    Assert.Equal(15, (distinctPowersNonTailRecCount 2.0 5.0))
    Assert.Equal(69, (distinctPowersNonTailRecCount 2.0 10.0))
    Assert.Equal(9183, (distinctPowersNonTailRecCount 2.0 100.0))


// ModularImpl
[<Fact>]
let ``distinctPowersModularCount should return the correct count`` () =
    Assert.Equal(15, (distinctPowersModularCount 2.0 5.0))
    Assert.Equal(69, (distinctPowersModularCount 2.0 10.0))
    Assert.Equal(9183, (distinctPowersModularCount 2.0 100.0))

// MapImpl
[<Fact>]
let ``generatePowersListWithMap should return the correct list of powers`` () =
    Assert.Equal<List<float>>([ 4.0; 8.0; 16.0; 9.0; 27.0; 81.0; 16.0; 64.0; 256.0 ], (generatePowersListWithMap 2 4))
    Assert.Equal<List<float>>([ 4.0; 8.0; 9.0; 27.0 ], (generatePowersListWithMap 2 3))

[<Fact>]
let ``distinctPowersWithMapCount should return the correct count`` () =
    Assert.Equal(15, (distinctPowersWithMapCount 2 5))
    Assert.Equal(69, (distinctPowersWithMapCount 2 10))
    Assert.Equal(9183, (distinctPowersWithMapCount 2 100))

//ListGenerationImpl
[<Fact>]
let ``distinctPowersSeqCount should return the correct count`` () =
    Assert.Equal(15, (distinctPowersSeqCount 2 5))
    Assert.Equal(69, (distinctPowersSeqCount 2 10))
    Assert.Equal(9183, (distinctPowersSeqCount 2 100))

[<Fact>]
let ``takePowers should return the correct powers sequence`` () =
    Assert.Equal([ 4.0; 8.0; 16.0; 32.0 ], (takePowers 2 5))
    Assert.Equal([ 4.0; 8.0; 16.0; 32.0; 64.0; 128.0 ], (takePowers 2 7))

[<Fact>]
let ``distinctPowersWithInfiniteSequenceCount should return the correct count`` () =
    Assert.Equal(15, (distinctPowersWithInfiniteSequenceCount 5))
    Assert.Equal(69, (distinctPowersWithInfiniteSequenceCount 10))
    Assert.Equal(9183, (distinctPowersWithInfiniteSequenceCount 100))
