module Euler2Tests

open Xunit
open Euler2.RecursionImpl
open Euler2.ModularImpl
open Euler2.MapImpl
open Euler2.ListGenerationImpl

// RecursionImpl
[<Fact>]
let ``fibonacciSumNonTailRec should return the correct sum`` () =
    let notEven x = x % 2 = 1
    Assert.Equal(44, (fibonacciSumNonTailRecFunction 50 UtilitiesImpl.isEven))
    Assert.Equal(188, (fibonacciSumNonTailRecFunction 100 notEven))

[<Fact>]
let ``fibonacciSumTailRec should return the correct sum`` () =
    let notEven x = x % 2 = 1
    Assert.Equal(44, (fibonacciSumTailRecFunction 50 UtilitiesImpl.isEven))
    Assert.Equal(188, (fibonacciSumTailRecFunction 100 notEven))

// ModularImpl
[<Fact>]
let ``filterAndSumFibonacciSequence should filter and sum the Fibonacci sequence correctly`` () =
    Assert.Equal(10, (filterAndSumFibonacciSequence 20 UtilitiesImpl.isEven))
    Assert.Equal(44, (filterAndSumFibonacciSequence 50 UtilitiesImpl.isEven))

// MapImpl
[<Fact>]
let ``fibonacciWithMap should return the correct Fibonacci sequence`` () =
    Assert.Equal<List<int>>([ 1 ], (fibonacciWithMap 1))
    Assert.Equal<List<int>>([ 1; 1 ], (fibonacciWithMap 2))
    Assert.Equal<List<int>>([ 1; 1; 2; 3; 5; 8; 13 ], (fibonacciWithMap 7))

[<Fact>]
let ``sumOfFibonacciWithWithMap should return the correct sum`` () =
    let notEven x = x % 2 = 1
    Assert.Equal(44, (sumOfFibonacciWithWithMap 50 UtilitiesImpl.isEven))
    Assert.Equal(188, (sumOfFibonacciWithWithMap 100 notEven))

//ListGenerationImpl
[<Fact>]
let ``fibonacciFold should return the correct Fibonacci sequence`` () =
    Assert.Equal(0, (fibonacciFold 0))
    Assert.Equal(5, (fibonacciFold 5))
    Assert.Equal(55, (fibonacciFold 10))

[<Fact>]
let ``findIndexOfBorderlineFibonacciElementUsingFold should return the correct index`` () =
    Assert.Equal(10, (findIndexOfBorderlineFibonacciElementUsingFold 1 55))
    Assert.Equal(11, (findIndexOfBorderlineFibonacciElementUsingFold 1 89))

[<Fact>]
let ``sumFibonacciInfiniteSequence should return the correct sum`` () =
    let notEven x = x % 2 = 1
    Assert.Equal(44, (sumFibonacciInfiniteSequence 50 UtilitiesImpl.isEven))
    Assert.Equal(188, (sumFibonacciInfiniteSequence 100 notEven))

[<Fact>]
let ``sumFibonacciFold should return the correct sum`` () =
    let notEven x = x % 2 = 0
    Assert.Equal(44, (sumFibonacciFold 50 UtilitiesImpl.isEven))
    Assert.Equal(188, (sumFibonacciFold 100 notEven))
