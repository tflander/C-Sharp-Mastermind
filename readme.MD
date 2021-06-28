# Building a testing DSL (Domain Specific Language) using the Mastermind Kata

## Directions:

Practice implementing an internal DSL for the MasterMind kata.  Write tests using fluent style implementing a cusom gherkin-style DSL.

For an in-depth study, refer to Martin Fowler's book [Domain Specific Languages](https://martinfowler.com/books/dsl.html)
### TODO:

1.  Look at the following block in [GameTest.cs](https://github.com/tflander/C-Sharp-Mastermind/blob/main/MasterMindTests/GameTest.cs):

```C#
[Test]
public void Win()
{
  var game = new Game("RGBO");
  Assert.That(game.Guess("RGBO"), Is.EqualTo("Won!"));
  // Given.GameWithSolution("RGBO").WhenGuess("RGBO").ThenAnswerIs("Won!");
}
```

2. Uncomment the line `Given.GameWithSolution("RGBO").WhenGuess("RGBO").ThenAnswerIs("Won!");`
3. Verify Undefined Type error
4. Define the type and implement the DSL
5. Very new DSL function runs green
6. Delete the original test code


## The Original Kata Rules:

1. The Mastermind (computer) will select 4 colours. The colours are randomly selected from ["Red", "Blue", "Green", "Orange", "Purple", "Yellow"]. Colours can be duplicated but there will always be exactly 4.

2. The Mastermind will return an array back to you. For every correctly positioned colour in the array an element of “Black” is returned. For every correct colour but in the wrong position an element of “White” will be returned.

3. Passing the correct array will pass the Kata test and return "WON!".

4. Passing an invalid colour will fail the test with the error "Error: you have given an invalid colour!"

5. Passing an invalid array length will fail the test with the error "Error: you must pass 4 colours!"

6. Guessing more than 60 times will fail the test with the error "Error: you have had more than 60 tries!"

7. All colours are capitalised

8. The return array will be shuffled!
