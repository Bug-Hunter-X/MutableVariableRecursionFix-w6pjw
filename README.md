# F# Mutable Variable Issue in Recursive Function

This repository demonstrates an unexpected behavior in a recursive F# function that uses mutable variables. The `loop` function is intended to increment `x` until it reaches 10, and then increment `y` until it reaches 5. However, due to the way mutable variables are handled in the recursive calls, the final values of `x` and `y` are not what one might initially expect. 

The `bug.fs` file contains the problematic code, and the `bugSolution.fs` file provides a corrected version using immutable values for a clearer and more predictable behavior.