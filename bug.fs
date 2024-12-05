let mutable x = 10

let addOne x = x + 1

let y = addOne x

printfn "%d" y //Prints 11
x //Prints 10, not 11 as one might expect

This is because F# is immutable by default.  The addOne function creates a new value (11), but does not modify the original variable x. Mutable variables are explicitly declared with mutable.