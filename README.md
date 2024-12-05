# F# Immutability Gotcha: Unexpected Behavior with Mutable Variables

This example demonstrates a common misunderstanding in F# regarding immutability.  Many programmers coming from mutable-centric languages can be surprised that modifying a value doesn't affect the original variable unless it's explicitly declared as mutable.

The `bug.fs` file contains code that showcases this issue. The `bugSolution.fs` file offers a corrected version.

## How to reproduce the problem

1. Compile and run `bug.fs`.
2. Observe that although `addOne` seemingly increments `x`, the printed value of `x` remains unchanged. 

## Understanding the Solution

The solution lies in the correct use of mutable variables. By declaring `x` as `mutable`, the `addOne` function now modifies the original value of `x` in place.  Read more about F# immutability and mutability in the official documentation.