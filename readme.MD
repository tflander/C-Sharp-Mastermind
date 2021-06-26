Mastermind Kata

1. The Mastermind (computer) will select 4 colours. The colours are randomly selected from ["Red", "Blue", "Green", "Orange", "Purple", "Yellow"]. Colours can be duplicated but there will always be exactly 4.

2. The Mastermind will return an array back to you. For every correctly positioned colour in the array an element of “Black” is returned. For every correct colour but in the wrong position an element of “White” will be returned.

3. Passing the correct array will pass the Kata test and return "WON!".

4. Passing an invalid colour will fail the test with the error "Error: you have given an invalid colour!"

5. Passing an invalid array length will fail the test with the error "Error: you must pass 4 colours!"

6. Guessing more than 60 times will fail the test with the error "Error: you have had more than 60 tries!"

7. All colours are capitalised

8. The return array will be shuffled!