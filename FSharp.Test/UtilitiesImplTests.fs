module UtilitiesImplTests

open Xunit
open UtilitiesImpl

[<Fact>]
let ``isEven should return true for even numbers`` () =
    Assert.True(isEven 4)
    Assert.True(isEven 0)

[<Fact>]
let ``isEven should return false for odd numbers`` () =
    Assert.False(isEven 3)
    Assert.False(isEven 7)

[<Fact>]
let ``inc should increment the given number by 1`` () =
    Assert.Equal(6, (inc 5))
    Assert.Equal(0, (inc -1))

[<Fact>]
let ``sumTwoDigits should return the sum of two given digits`` () =
    Assert.Equal(7, (sumTwoDigits 3 4))
    Assert.Equal(10, (sumTwoDigits 5 5))

[<Fact>]
let ``sumList should return the sum of all elements in a list`` () =
    Assert.Equal(15, (sumList [ 1; 2; 3; 4; 5 ]))
    Assert.Equal(0, (sumList []))

[<Fact>]
let ``filterList should return a new list with elements that satisfy the predicate`` () =
    let isPositive x = x > 0
    let input = [ -2; -1; 0; 1; 2 ]
    let expectedOutput = [ 1; 2 ]
    Assert.Equal<List<int>>(expectedOutput, (filterList isPositive input))

[<Fact>]
let ``lessThan should return a function that checks if a value is less than the specified value`` () =
    let lessThanFive = lessThan 5
    Assert.True(lessThanFive 3)
    Assert.False(lessThanFive 7)

[<Fact>]
let ``fibonacciRec should return the correct Fibonacci number`` () =
    Assert.Equal(1, (fibonacciRec 1))
    Assert.Equal(1, (fibonacciRec 2))
    Assert.Equal(8, (fibonacciRec 6))

[<Fact>]
let ``fibonacciTailRec should return the correct Fibonacci number`` () =
    Assert.Equal(1, (fibonacciTailRecFunction 1))
    Assert.Equal(1, (fibonacciTailRecFunction 2))
    Assert.Equal(8, (fibonacciTailRecFunction 6))

[<Fact>]
let ``findIndexOfBorderlineFibonacciElement should return the correct index`` () =
    Assert.Equal(10, (findIndexOfBorderlineFibonacciElement 1 55))
    Assert.Equal(11, (findIndexOfBorderlineFibonacciElement 1 89))

[<Fact>]
let ``generateFibonacciSequenceList should return the correct Fibonacci sequence`` () =
    Assert.Equal<List<int>>([ 1; 1; 2; 3; 5; 8; 13; 21 ], (generateFibonacciSequenceList 23))
    Assert.Equal<List<int>>([ 1; 1; 2; 3; 5; 8; 13; 21; 34; 55; 89 ], (generateFibonacciSequenceList 100))

[<Fact>]
let ``power should calculate the correct power`` () =
    Assert.Equal(8I, (power 2 3I))
    Assert.Equal(16I, (power 2 4I))

[<Fact>]
let ``calculatePowersSet should calculate the powers set correctly`` () =
    let expectedSet = Set.ofList [ 4.0; 8.0; 16.0; 32.0 ]
    let actualSet = calculatePowersSet 2.0 2 5.0 Set.empty
    Assert.Equal<Set<float>>(expectedSet, actualSet)

[<Fact>]
let ``generatePowersList should generate the correct powers list`` () =
    let expectedList =
        [ 4.0
          8.0
          16.0
          32.0
          9.0
          27.0
          81.0
          243.0
          16.0
          64.0
          256.0
          1024.0
          25.0
          125.0
          625.0
          3125.0 ]

    let actualList = generatePowersList 2.0 5.0 []
    Assert.Equal<List<float>>(expectedList, actualList)

[<Fact>]
let ``generateUsingSequence should return the correct length`` () =
    Assert.Equal(9183, (generateUsingSequence))
